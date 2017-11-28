﻿
namespace BizHawk.Emulation.Cores.Computers.SinclairSpectrum
{
    /// <summary>
    /// Represents the standard speed data block in a tape file
    /// </summary>
    public class TapeDataBlockPlayer : ISupportsTapeBlockPlayback, ITapeData
    {
        /// <summary>
        /// Pause after this block (default: 1000ms)
        /// </summary>
        public ushort PauseAfter { get; }

        /// <summary>
        /// Block Data
        /// </summary>
        public byte[] Data { get; }

        /// <summary>
        /// Initializes a new instance
        /// </summary>
        public TapeDataBlockPlayer(byte[] data, ushort pauseAfter)
        {
            PauseAfter = pauseAfter;
            Data = data;
        }

        /// <summary>
        /// Pilot pulse length
        /// </summary>
        public const int PILOT_PL = 2168;

        /// <summary>
        /// Pilot pulses in the ROM header block
        /// </summary>
        public const int HEADER_PILOT_COUNT = 8063;

        /// <summary>
        /// Pilot pulses in the ROM data block
        /// </summary>
        public const int DATA_PILOT_COUNT = 3223;

        /// <summary>
        /// Sync 1 pulse length
        /// </summary>
        public const int SYNC_1_PL = 667;

        /// <summary>
        /// Sync 2 pulse lenth
        /// </summary>
        public const int SYNC_2_PL = 735;

        /// <summary>
        /// Bit 0 pulse length
        /// </summary>
        public const int BIT_0_PL = 855;

        /// <summary>
        /// Bit 1 pulse length
        /// </summary>
        public const int BIT_1_PL = 1710;

        /// <summary>
        /// End sync pulse length
        /// </summary>
        public const int TERM_SYNC = 947;

        /// <summary>
        /// 1 millisecond pause
        /// </summary>
        public const int PAUSE_MS = 3500;

        private int _pilotEnds;
        private int _sync1Ends;
        private int _sync2Ends;
        private int _bitStarts;
        private int _bitPulseLength;
        private bool _currentBit;
        private long _termSyncEnds;
        private long _pauseEnds;

        /// <summary>
        /// The index of the currently playing byte
        /// </summary>
        public int ByteIndex { get; private set; }

        /// <summary>
        /// The mask of the currently playing bit in the current byte
        /// </summary>
        public byte BitMask { get; private set; }

        /// <summary>
        /// The current playing phase
        /// </summary>
        public PlayPhase PlayPhase { get; private set; }

        /// <summary>
        /// The cycle count of the CPU when playing starts
        /// </summary>
        public long StartCycle { get; private set; }

        /// <summary>
        /// Last cycle queried
        /// </summary>
        public long LastCycle { get; private set; }

        /// <summary>
        /// Initializes the player
        /// </summary>
        public void InitPlay(long startTact)
        {
            PlayPhase = PlayPhase.Pilot;
            StartCycle = LastCycle = startTact;
            _pilotEnds = ((Data[0] & 0x80) == 0 ? HEADER_PILOT_COUNT : DATA_PILOT_COUNT) * PILOT_PL;
            _sync1Ends = _pilotEnds + SYNC_1_PL;
            _sync2Ends = _sync1Ends + SYNC_2_PL;
            ByteIndex = 0;
            BitMask = 0x80;
        }

        /// <summary>
        /// Gets the EAR bit value for the specified cycle
        /// </summary>
        /// <param name="currentCycle">Tacts to retrieve the EAR bit</param>
        /// <returns>
        /// The EAR bit value to play back
        /// </returns>
        public bool GetEarBit(long currentCycle)
        {
            var pos = (int)(currentCycle - StartCycle);
            LastCycle = currentCycle;

            if (PlayPhase == PlayPhase.Pilot || PlayPhase == PlayPhase.Sync)
            {
                // --- Generate the appropriate pilot or sync EAR bit
                if (pos <= _pilotEnds)
                {
                    // --- Alternating pilot pulses
                    return (pos / PILOT_PL) % 2 == 0;
                }
                if (pos <= _sync1Ends)
                {
                    // --- 1st sync pulse
                    PlayPhase = PlayPhase.Sync;
                    return false;
                }
                if (pos <= _sync2Ends)
                {
                    // --- 2nd sync pulse
                    PlayPhase = PlayPhase.Sync;
                    return true;
                }
                PlayPhase = PlayPhase.Data;
                _bitStarts = _sync2Ends;
                _currentBit = (Data[ByteIndex] & BitMask) != 0;
                _bitPulseLength = _currentBit ? BIT_1_PL : BIT_0_PL;
            }
            if (PlayPhase == PlayPhase.Data)
            {
                // --- Data block playback
                // --- Generate current bit pulse
                var bitPos = pos - _bitStarts;
                if (bitPos < _bitPulseLength)
                {
                    // --- First pulse of the bit
                    return false;
                }
                if (bitPos < 2 * _bitPulseLength)
                {
                    // --- Second pulse of the bit
                    return true;
                }

                // --- Move to the next bit, or byte
                if ((BitMask >>= 1) == 0)
                {
                    BitMask = 0x80;
                    ByteIndex++;
                }

                // --- Prepare the next bit
                if (ByteIndex < Data.Length)
                {
                    _bitStarts += 2 * _bitPulseLength;
                    _currentBit = (Data[ByteIndex] & BitMask) != 0;
                    _bitPulseLength = _currentBit ? BIT_1_PL : BIT_0_PL;
                    // --- We're in the first pulse of the next bit
                    return false;
                }

                // --- We've played back all data bytes, send terminating pulse
                PlayPhase = PlayPhase.TermSync;
                _termSyncEnds = currentCycle + TERM_SYNC;
                return false;
            }

            if (PlayPhase == PlayPhase.TermSync)
            {
                if (currentCycle < _termSyncEnds)
                {
                    return false;
                }

                // --- We've played back all data, not, it's pause time
                PlayPhase = PlayPhase.Pause;
                _pauseEnds = currentCycle + PAUSE_MS * PauseAfter;
                return true;
            }

            // --- We need to produce pause signs
            if (currentCycle > _pauseEnds)
            {
                PlayPhase = PlayPhase.Completed;
            }
            return true;
        }
    }
}
