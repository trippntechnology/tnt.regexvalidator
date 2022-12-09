namespace TNT.VSRegexValidator
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.IgnoreCaseMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.MultilineMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.TextBox = new System.Windows.Forms.TextBox();
			this.Expression = new System.Windows.Forms.TextBox();
			this.Result = new System.Windows.Forms.TextBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.OpenButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.IgnoreCaseButton = new System.Windows.Forms.ToolStripButton();
			this.MultilineButton = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(810, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenu});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// OpenMenu
			// 
			this.OpenMenu.Name = "OpenMenu";
			this.OpenMenu.Size = new System.Drawing.Size(103, 22);
			this.OpenMenu.Text = "Open";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IgnoreCaseMenu,
            this.MultilineMenu});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// IgnoreCaseMenu
			// 
			this.IgnoreCaseMenu.AutoToolTip = true;
			this.IgnoreCaseMenu.CheckOnClick = true;
			this.IgnoreCaseMenu.Name = "IgnoreCaseMenu";
			this.IgnoreCaseMenu.Size = new System.Drawing.Size(136, 22);
			this.IgnoreCaseMenu.Text = "Ignore Case";
			// 
			// MultilineMenu
			// 
			this.MultilineMenu.CheckOnClick = true;
			this.MultilineMenu.Name = "MultilineMenu";
			this.MultilineMenu.Size = new System.Drawing.Size(136, 22);
			this.MultilineMenu.Text = "Multiline";
			// 
			// OpenFileDialog
			// 
			this.OpenFileDialog.DefaultExt = "*.*";
			this.OpenFileDialog.FileName = "openFileDialog1";
			this.OpenFileDialog.Filter = "All files (*.*)|*.*|HL7 files (*.hl7)|*.hl7|Text files (*.txt)|*.txt";
			this.OpenFileDialog.Title = "Open";
			// 
			// TextBox
			// 
			this.TextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.TextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBox.Location = new System.Drawing.Point(0, 49);
			this.TextBox.Multiline = true;
			this.TextBox.Name = "TextBox";
			this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TextBox.Size = new System.Drawing.Size(810, 400);
			this.TextBox.TabIndex = 1;
			this.TextBox.WordWrap = false;
			// 
			// Expression
			// 
			this.Expression.Dock = System.Windows.Forms.DockStyle.Top;
			this.Expression.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Expression.Location = new System.Drawing.Point(0, 452);
			this.Expression.Name = "Expression";
			this.Expression.Size = new System.Drawing.Size(810, 20);
			this.Expression.TabIndex = 2;
			this.Expression.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Expression_KeyUp);
			// 
			// Result
			// 
			this.Result.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Result.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Result.Location = new System.Drawing.Point(0, 472);
			this.Result.Multiline = true;
			this.Result.Name = "Result";
			this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Result.Size = new System.Drawing.Size(810, 160);
			this.Result.TabIndex = 3;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 449);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(810, 3);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenButton,
            this.toolStripSeparator1,
            this.IgnoreCaseButton,
            this.MultilineButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(810, 25);
			this.toolStrip1.TabIndex = 6;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// OpenButton
			// 
			this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.OpenButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenButton.Image")));
			this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OpenButton.Name = "OpenButton";
			this.OpenButton.Size = new System.Drawing.Size(23, 22);
			this.OpenButton.Text = "Open";
			this.OpenButton.ToolTipText = "Open File";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// IgnoreCaseButton
			// 
			this.IgnoreCaseButton.CheckOnClick = true;
			this.IgnoreCaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.IgnoreCaseButton.Image = ((System.Drawing.Image)(resources.GetObject("IgnoreCaseButton.Image")));
			this.IgnoreCaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.IgnoreCaseButton.Name = "IgnoreCaseButton";
			this.IgnoreCaseButton.Size = new System.Drawing.Size(23, 22);
			this.IgnoreCaseButton.Text = "Ignore Case";
			this.IgnoreCaseButton.ToolTipText = "Ignore character case";
			// 
			// MultilineButton
			// 
			this.MultilineButton.Checked = true;
			this.MultilineButton.CheckOnClick = true;
			this.MultilineButton.CheckState = System.Windows.Forms.CheckState.Checked;
			this.MultilineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.MultilineButton.Image = ((System.Drawing.Image)(resources.GetObject("MultilineButton.Image")));
			this.MultilineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MultilineButton.Name = "MultilineButton";
			this.MultilineButton.Size = new System.Drawing.Size(23, 22);
			this.MultilineButton.Text = "Multiline";
			this.MultilineButton.ToolTipText = "Enables multiline search";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 632);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(810, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(810, 654);
			this.Controls.Add(this.Result);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.Expression);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.TextBox);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "VS Regular Expression Validator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_FormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenMenu;
		private System.Windows.Forms.OpenFileDialog OpenFileDialog;
		public System.Windows.Forms.TextBox TextBox;
		private System.Windows.Forms.TextBox Expression;
		private System.Windows.Forms.TextBox Result;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem IgnoreCaseMenu;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton OpenButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton IgnoreCaseButton;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripMenuItem MultilineMenu;
		private System.Windows.Forms.ToolStripButton MultilineButton;
	}
}

