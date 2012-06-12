﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BizHawk.MultiClient
{
	public partial class HexColors_Form : Form
	{
		public HexColors_Form()
		{
			InitializeComponent();
		}

		private void HexColors_Form_Load(object sender, EventArgs e)
		{
			HexBackgrnd.BackColor = Global.Config.HexBackgrndColor;
			HexForegrnd.BackColor = Global.Config.HexForegrndColor;
			HexMenubar.BackColor = Global.Config.HexMenubarColor;
			HexFreeze.BackColor = Global.Config.HexFreezeColor;
			HexFreezeHL.BackColor = Global.Config.HexHighlightFreezeColor;
			HexHighlight.BackColor = Global.Config.HexHighlightColor;
		}

		private void HexBackgrnd_Click(Object sender, MouseEventArgs e)
		{
			if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Global.Config.HexBackgrndColor = colorDialog1.Color;
				Global.MainForm.HexEditor1.MemoryViewerBox.BackColor = Global.Config.HexBackgrndColor;
				this.HexBackgrnd.BackColor = colorDialog1.Color;
			}
		}

		private void HexForegrnd_Click(Object sender, MouseEventArgs e)
		{
			if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Global.Config.HexForegrndColor = colorDialog1.Color;
				Global.MainForm.HexEditor1.MemoryViewerBox.ForeColor = Global.Config.HexForegrndColor;
				this.HexForegrnd.BackColor = colorDialog1.Color;

			}
		}

		private void HexMenubar_Click(Object sender, MouseEventArgs e)
		{
			if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Global.Config.HexMenubarColor = colorDialog1.Color;
				Global.MainForm.HexEditor1.menuStrip1.BackColor = Global.Config.HexMenubarColor;
				this.HexMenubar.BackColor = colorDialog1.Color;
			}
		}

		private void HexHighlight_Click(Object sender, MouseEventArgs e)
		{
			if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Global.Config.HexHighlightColor = colorDialog1.Color;
				this.HexHighlight.BackColor = colorDialog1.Color;
			}
		}

		private void HexFreeze_Click(Object sender, MouseEventArgs e)
		{
			if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Global.Config.HexFreezeColor = colorDialog1.Color;
				this.HexFreeze.BackColor = colorDialog1.Color;
			}
		}

		private void HexFreezeHL_Click(Object sender, MouseEventArgs e)
		{
			if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Global.Config.HexHighlightFreezeColor = colorDialog1.Color;
				this.HexFreezeHL.BackColor = colorDialog1.Color;
			}
		}
	}
}
