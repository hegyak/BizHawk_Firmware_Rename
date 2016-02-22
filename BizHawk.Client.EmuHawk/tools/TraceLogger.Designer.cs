﻿namespace BizHawk.Client.EmuHawk
{
	partial class TraceLogger
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraceLogger));
			this.TracerBox = new System.Windows.Forms.GroupBox();
			this.TraceView = new BizHawk.Client.EmuHawk.VirtualListView();
			this.Disasm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Registers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.menuStrip1 = new MenuStripEx();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.FileSubMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditSubMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SelectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsSubMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.MaxLinesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.BrowseBox = new System.Windows.Forms.Button();
			this.FileBox = new System.Windows.Forms.TextBox();
			this.ToFileRadio = new System.Windows.Forms.RadioButton();
			this.ToWindowRadio = new System.Windows.Forms.RadioButton();
			this.ClearButton = new System.Windows.Forms.Button();
			this.LoggingEnabled = new System.Windows.Forms.CheckBox();
			this.TracerBox.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// TracerBox
			// 
			this.TracerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TracerBox.Controls.Add(this.TraceView);
			this.TracerBox.Location = new System.Drawing.Point(12, 27);
			this.TracerBox.Name = "TracerBox";
			this.TracerBox.Size = new System.Drawing.Size(620, 444);
			this.TracerBox.TabIndex = 1;
			this.TracerBox.TabStop = false;
			this.TracerBox.Text = "Trace log";
			// 
			// TraceView
			// 
			this.TraceView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TraceView.BlazingFast = false;
			this.TraceView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Disasm,
            this.Registers});
			this.TraceView.Font = new System.Drawing.Font("Courier New", 8F);
			this.TraceView.FullRowSelect = true;
			this.TraceView.GridLines = true;
			this.TraceView.HideSelection = false;
			this.TraceView.ItemCount = 0;
			this.TraceView.Location = new System.Drawing.Point(8, 18);
			this.TraceView.Name = "TraceView";
			this.TraceView.SelectAllInProgress = false;
			this.TraceView.selectedItem = -1;
			this.TraceView.Size = new System.Drawing.Size(603, 414);
			this.TraceView.TabIndex = 4;
			this.TraceView.TabStop = false;
			this.TraceView.UseCompatibleStateImageBehavior = false;
			this.TraceView.UseCustomBackground = true;
			this.TraceView.View = System.Windows.Forms.View.Details;
			// 
			// Disasm
			// 
			this.Disasm.Text = "Disasm";
			this.Disasm.Width = 239;
			// 
			// Registers
			// 
			this.Registers.Text = "Registers";
			this.Registers.Width = 357;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ClickThrough = true;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.FileSubMenu,
            this.EditSubMenu,
            this.OptionsSubMenu});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(644, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
			// 
			// FileSubMenu
			// 
			this.FileSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveLogMenuItem,
            this.toolStripSeparator1,
            this.ExitMenuItem});
			this.FileSubMenu.Name = "FileSubMenu";
			this.FileSubMenu.Size = new System.Drawing.Size(35, 20);
			this.FileSubMenu.Text = "&File";
			// 
			// SaveLogMenuItem
			// 
			this.SaveLogMenuItem.Image = global::BizHawk.Client.EmuHawk.Properties.Resources.SaveAs;
			this.SaveLogMenuItem.Name = "SaveLogMenuItem";
			this.SaveLogMenuItem.Size = new System.Drawing.Size(132, 22);
			this.SaveLogMenuItem.Text = "&Save Log";
			this.SaveLogMenuItem.Click += new System.EventHandler(this.SaveLogMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
			// 
			// ExitMenuItem
			// 
			this.ExitMenuItem.Name = "ExitMenuItem";
			this.ExitMenuItem.ShortcutKeyDisplayString = "Alt+F4";
			this.ExitMenuItem.Size = new System.Drawing.Size(132, 22);
			this.ExitMenuItem.Text = "E&xit";
			this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
			// 
			// EditSubMenu
			// 
			this.EditSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyMenuItem,
            this.SelectAllMenuItem});
			this.EditSubMenu.Name = "EditSubMenu";
			this.EditSubMenu.Size = new System.Drawing.Size(37, 20);
			this.EditSubMenu.Text = "Edit";
			// 
			// CopyMenuItem
			// 
			this.CopyMenuItem.Name = "CopyMenuItem";
			this.CopyMenuItem.ShortcutKeyDisplayString = "";
			this.CopyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.CopyMenuItem.Size = new System.Drawing.Size(156, 22);
			this.CopyMenuItem.Text = "&Copy";
			this.CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
			// 
			// SelectAllMenuItem
			// 
			this.SelectAllMenuItem.Name = "SelectAllMenuItem";
			this.SelectAllMenuItem.ShortcutKeyDisplayString = "";
			this.SelectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.SelectAllMenuItem.Size = new System.Drawing.Size(156, 22);
			this.SelectAllMenuItem.Text = "Select &All";
			this.SelectAllMenuItem.Click += new System.EventHandler(this.SelectAllMenuItem_Click);
			// 
			// OptionsSubMenu
			// 
			this.OptionsSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaxLinesMenuItem});
			this.OptionsSubMenu.Name = "OptionsSubMenu";
			this.OptionsSubMenu.Size = new System.Drawing.Size(58, 20);
			this.OptionsSubMenu.Text = "&Settings";
			// 
			// MaxLinesMenuItem
			// 
			this.MaxLinesMenuItem.Name = "MaxLinesMenuItem";
			this.MaxLinesMenuItem.Size = new System.Drawing.Size(152, 22);
			this.MaxLinesMenuItem.Text = "&Set Max Lines...";
			this.MaxLinesMenuItem.Click += new System.EventHandler(this.MaxLinesMenuItem_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.BrowseBox);
			this.groupBox2.Controls.Add(this.FileBox);
			this.groupBox2.Controls.Add(this.ToFileRadio);
			this.groupBox2.Controls.Add(this.ToWindowRadio);
			this.groupBox2.Controls.Add(this.ClearButton);
			this.groupBox2.Controls.Add(this.LoggingEnabled);
			this.groupBox2.Location = new System.Drawing.Point(12, 477);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(620, 50);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Control";
			// 
			// BrowseBox
			// 
			this.BrowseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BrowseBox.Location = new System.Drawing.Point(477, 19);
			this.BrowseBox.Name = "BrowseBox";
			this.BrowseBox.Size = new System.Drawing.Size(54, 23);
			this.BrowseBox.TabIndex = 20;
			this.BrowseBox.Text = "&Browse";
			this.BrowseBox.UseVisualStyleBackColor = true;
			this.BrowseBox.Visible = false;
			this.BrowseBox.Click += new System.EventHandler(this.BrowseBox_Click);
			// 
			// FileBox
			// 
			this.FileBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FileBox.Location = new System.Drawing.Point(229, 20);
			this.FileBox.Name = "FileBox";
			this.FileBox.ReadOnly = true;
			this.FileBox.Size = new System.Drawing.Size(242, 20);
			this.FileBox.TabIndex = 15;
			this.FileBox.TabStop = false;
			this.FileBox.Visible = false;
			// 
			// ToFileRadio
			// 
			this.ToFileRadio.AutoSize = true;
			this.ToFileRadio.Location = new System.Drawing.Point(173, 22);
			this.ToFileRadio.Name = "ToFileRadio";
			this.ToFileRadio.Size = new System.Drawing.Size(50, 17);
			this.ToFileRadio.TabIndex = 10;
			this.ToFileRadio.Text = "to file";
			this.ToFileRadio.UseVisualStyleBackColor = true;
			this.ToFileRadio.CheckedChanged += new System.EventHandler(this.ToFileRadio_CheckedChanged);
			// 
			// ToWindowRadio
			// 
			this.ToWindowRadio.AutoSize = true;
			this.ToWindowRadio.Checked = true;
			this.ToWindowRadio.Location = new System.Drawing.Point(94, 22);
			this.ToWindowRadio.Name = "ToWindowRadio";
			this.ToWindowRadio.Size = new System.Drawing.Size(73, 17);
			this.ToWindowRadio.TabIndex = 5;
			this.ToWindowRadio.TabStop = true;
			this.ToWindowRadio.Text = "to window";
			this.ToWindowRadio.UseVisualStyleBackColor = true;
			// 
			// ClearButton
			// 
			this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearButton.Location = new System.Drawing.Point(564, 19);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(47, 23);
			this.ClearButton.TabIndex = 25;
			this.ClearButton.Text = "&Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// LoggingEnabled
			// 
			this.LoggingEnabled.Appearance = System.Windows.Forms.Appearance.Button;
			this.LoggingEnabled.AutoSize = true;
			this.LoggingEnabled.Location = new System.Drawing.Point(9, 19);
			this.LoggingEnabled.Name = "LoggingEnabled";
			this.LoggingEnabled.Size = new System.Drawing.Size(55, 23);
			this.LoggingEnabled.TabIndex = 1;
			this.LoggingEnabled.Text = "&Logging";
			this.LoggingEnabled.UseVisualStyleBackColor = true;
			this.LoggingEnabled.CheckedChanged += new System.EventHandler(this.LoggingEnabled_CheckedChanged);
			// 
			// TraceLogger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 539);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.TracerBox);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(400, 230);
			this.Name = "TraceLogger";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "TraceLogger";
			this.Load += new System.EventHandler(this.TraceLogger_Load);
			this.TracerBox.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox TracerBox;
		private MenuStripEx menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem FileSubMenu;
		private System.Windows.Forms.ToolStripMenuItem SaveLogMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox LoggingEnabled;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.ToolStripMenuItem OptionsSubMenu;
		private VirtualListView TraceView;
		public System.Windows.Forms.ColumnHeader Disasm;
		private System.Windows.Forms.ToolStripMenuItem MaxLinesMenuItem;
		private System.Windows.Forms.RadioButton ToFileRadio;
		private System.Windows.Forms.RadioButton ToWindowRadio;
		private System.Windows.Forms.TextBox FileBox;
		private System.Windows.Forms.Button BrowseBox;
		private System.Windows.Forms.ToolStripMenuItem EditSubMenu;
		private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SelectAllMenuItem;
		private System.Windows.Forms.ColumnHeader Registers;
	}
}