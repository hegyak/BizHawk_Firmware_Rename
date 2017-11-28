﻿
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BizHawk.Emulation.Cores.Computers.SinclairSpectrum
{
    /// <summary>
    /// This class is responsible to "play" a TAP file.
    /// </summary>
    public class TapPlayer : TapReader, ISupportsTapeBlockPlayback
    {
        private TapeBlockSetPlayer _player;

        /// <summary>
        /// Signs that the player completed playing back the file
        /// </summary>
        public bool Eof => _player.Eof;

        /// <summary>
        /// Initializes the player from the specified reader
        /// </summary>
        /// <param name="reader">BinaryReader instance to get TZX file data from</param>
        public TapPlayer(BinaryReader reader) : base(reader)
        {
        }

        /// <summary>
        /// Reads in the content of the TZX file so that it can be played
        /// </summary>
        /// <returns>True, if read was successful; otherwise, false</returns>
        public override bool ReadContent()
        {
            var success = base.ReadContent();

            var blocks = DataBlocks.Cast<ISupportsTapeBlockPlayback>()
                .ToList();
            _player = new TapeBlockSetPlayer(blocks);
            return success;
        }

        /// <summary>
        /// Gets the currently playing block's index
        /// </summary>
        public int CurrentBlockIndex => _player.CurrentBlockIndex;

        /// <summary>
        /// The current playable block
        /// </summary>
        public ISupportsTapeBlockPlayback CurrentBlock => _player.CurrentBlock;

        /// <summary>
        /// The current playing phase
        /// </summary>
        public PlayPhase PlayPhase => _player.PlayPhase;

        /// <summary>
        /// The tact count of the CPU when playing starts
        /// </summary>
        public long StartCycle => _player.StartCycle;

        /// <summary>
        /// Initializes the player
        /// </summary>
        public void InitPlay(long startCycle)
        {
            _player.InitPlay(startCycle);
        }

        /// <summary>
        /// Gets the EAR bit value for the specified tact
        /// </summary>
        /// <param name="currentCycle">Tacts to retrieve the EAR bit</param>
        /// <returns>
        /// A tuple of the EAR bit and a flag that indicates it is time to move to the next block
        /// </returns>
        public bool GetEarBit(long currentCycle) => _player.GetEarBit(currentCycle);

        /// <summary>
        /// Moves the current block index to the next playable block
        /// </summary>
        /// <param name="currentCycle">Tacts time to start the next block</param>
        public void NextBlock(long currentCycle) => _player.NextBlock(currentCycle);
    }
}
