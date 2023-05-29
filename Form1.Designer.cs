namespace NVGNotes
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			textBox = new RichTextBox();
			groupBox1 = new GroupBox();
			label1 = new Label();
			fontSize = new NumericUpDown();
			resetButton = new Button();
			underlineBTN = new Button();
			italicButton = new Button();
			boldButton = new Button();
			clearButton = new Button();
			menu = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			printToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			cToolStripMenuItem = new ToolStripMenuItem();
			aboutToolStripMenuItem = new ToolStripMenuItem();
			aboutToolStripMenuItem1 = new ToolStripMenuItem();
			boldToolStripMenuItem = new ToolStripMenuItem();
			italicToolStripMenuItem = new ToolStripMenuItem();
			underlineToolStripMenuItem = new ToolStripMenuItem();
			aboutToolStripMenuItem2 = new ToolStripMenuItem();
			aboutNVGNotesToolStripMenuItem = new ToolStripMenuItem();
			saveFile = new SaveFileDialog();
			openFile = new OpenFileDialog();
			printFile = new PrintDialog();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)fontSize).BeginInit();
			menu.SuspendLayout();
			SuspendLayout();
			// 
			// textBox
			// 
			textBox.BorderStyle = BorderStyle.None;
			textBox.Location = new Point(12, 111);
			textBox.Name = "textBox";
			textBox.Size = new Size(776, 364);
			textBox.TabIndex = 0;
			textBox.Text = "";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(fontSize);
			groupBox1.Controls.Add(resetButton);
			groupBox1.Controls.Add(underlineBTN);
			groupBox1.Controls.Add(italicButton);
			groupBox1.Controls.Add(boldButton);
			groupBox1.Controls.Add(clearButton);
			groupBox1.Location = new Point(12, 27);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(776, 78);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Text Options";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(262, 22);
			label1.Name = "label1";
			label1.Size = new Size(54, 15);
			label1.TabIndex = 6;
			label1.Text = "Font Size";
			// 
			// fontSize
			// 
			fontSize.Location = new Point(262, 49);
			fontSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			fontSize.Name = "fontSize";
			fontSize.Size = new Size(120, 23);
			fontSize.TabIndex = 5;
			fontSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
			fontSize.ValueChanged += fontSize_ValueChanged;
			// 
			// resetButton
			// 
			resetButton.Location = new Point(168, 49);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(75, 23);
			resetButton.TabIndex = 4;
			resetButton.Text = "Reset Style";
			resetButton.UseVisualStyleBackColor = true;
			resetButton.Click += resetButton_Click;
			// 
			// underlineBTN
			// 
			underlineBTN.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
			underlineBTN.Location = new Point(168, 22);
			underlineBTN.Name = "underlineBTN";
			underlineBTN.Size = new Size(75, 23);
			underlineBTN.TabIndex = 3;
			underlineBTN.Text = "Underline";
			underlineBTN.UseVisualStyleBackColor = true;
			underlineBTN.Click += underlineBTN_Click;
			// 
			// italicButton
			// 
			italicButton.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
			italicButton.Location = new Point(87, 49);
			italicButton.Name = "italicButton";
			italicButton.Size = new Size(75, 23);
			italicButton.TabIndex = 2;
			italicButton.Text = "Italic";
			italicButton.UseVisualStyleBackColor = true;
			italicButton.Click += italicButton_Click;
			// 
			// boldButton
			// 
			boldButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			boldButton.Location = new Point(87, 22);
			boldButton.Name = "boldButton";
			boldButton.Size = new Size(75, 23);
			boldButton.TabIndex = 1;
			boldButton.Text = "Bold";
			boldButton.UseVisualStyleBackColor = true;
			boldButton.Click += boldButton_Click;
			// 
			// clearButton
			// 
			clearButton.Location = new Point(6, 22);
			clearButton.Name = "clearButton";
			clearButton.Size = new Size(75, 50);
			clearButton.TabIndex = 0;
			clearButton.Text = "Clear";
			clearButton.UseVisualStyleBackColor = true;
			clearButton.Click += clearButton_Click;
			// 
			// menu
			// 
			menu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem, aboutToolStripMenuItem2 });
			menu.Location = new Point(0, 0);
			menu.Name = "menu";
			menu.Size = new Size(800, 24);
			menu.TabIndex = 3;
			menu.Text = "menu";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, printToolStripMenuItem, openToolStripMenuItem, cToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
			saveToolStripMenuItem.Size = new Size(151, 22);
			saveToolStripMenuItem.Text = "Save";
			saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
			// 
			// printToolStripMenuItem
			// 
			printToolStripMenuItem.Name = "printToolStripMenuItem";
			printToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + P";
			printToolStripMenuItem.Size = new Size(151, 22);
			printToolStripMenuItem.Text = "Print";
			printToolStripMenuItem.Click += printToolStripMenuItem_Click;
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl  O";
			openToolStripMenuItem.Size = new Size(151, 22);
			openToolStripMenuItem.Text = "Open";
			openToolStripMenuItem.Click += openToolStripMenuItem_Click;
			// 
			// cToolStripMenuItem
			// 
			cToolStripMenuItem.Name = "cToolStripMenuItem";
			cToolStripMenuItem.ShortcutKeyDisplayString = "Alt + F4";
			cToolStripMenuItem.Size = new Size(151, 22);
			cToolStripMenuItem.Text = "Close";
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1, boldToolStripMenuItem, italicToolStripMenuItem, underlineToolStripMenuItem });
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size = new Size(39, 20);
			aboutToolStripMenuItem.Text = "Edit";
			// 
			// aboutToolStripMenuItem1
			// 
			aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			aboutToolStripMenuItem1.Size = new Size(125, 22);
			aboutToolStripMenuItem1.Text = "Clear";
			aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;
			// 
			// boldToolStripMenuItem
			// 
			boldToolStripMenuItem.Name = "boldToolStripMenuItem";
			boldToolStripMenuItem.Size = new Size(125, 22);
			boldToolStripMenuItem.Text = "Bold";
			boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
			// 
			// italicToolStripMenuItem
			// 
			italicToolStripMenuItem.Name = "italicToolStripMenuItem";
			italicToolStripMenuItem.Size = new Size(125, 22);
			italicToolStripMenuItem.Text = "Italic";
			italicToolStripMenuItem.Click += italicToolStripMenuItem_Click;
			// 
			// underlineToolStripMenuItem
			// 
			underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
			underlineToolStripMenuItem.Size = new Size(125, 22);
			underlineToolStripMenuItem.Text = "Underline";
			underlineToolStripMenuItem.Click += underlineToolStripMenuItem_Click;
			// 
			// aboutToolStripMenuItem2
			// 
			aboutToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { aboutNVGNotesToolStripMenuItem });
			aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
			aboutToolStripMenuItem2.Size = new Size(52, 20);
			aboutToolStripMenuItem2.Text = "About";
			// 
			// aboutNVGNotesToolStripMenuItem
			// 
			aboutNVGNotesToolStripMenuItem.Name = "aboutNVGNotesToolStripMenuItem";
			aboutNVGNotesToolStripMenuItem.Size = new Size(165, 22);
			aboutNVGNotesToolStripMenuItem.Text = "About NVGNotes";
			aboutNVGNotesToolStripMenuItem.Click += aboutNVGNotesToolStripMenuItem_Click;
			// 
			// printFile
			// 
			printFile.UseEXDialog = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(800, 487);
			Controls.Add(groupBox1);
			Controls.Add(textBox);
			Controls.Add(menu);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menu;
			Name = "Form1";
			Text = "NVGNotes";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)fontSize).EndInit();
			menu.ResumeLayout(false);
			menu.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RichTextBox textBox;
		private GroupBox groupBox1;
		private MenuStrip menu;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem printToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private ToolStripMenuItem cToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem1;
		private ToolStripMenuItem aboutToolStripMenuItem2;
		private ToolStripMenuItem aboutNVGNotesToolStripMenuItem;
		private Button clearButton;
		private Button italicButton;
		private Button boldButton;
		private ToolStripMenuItem boldToolStripMenuItem;
		private ToolStripMenuItem italicToolStripMenuItem;
		private Button underlineBTN;
		private ToolStripMenuItem underlineToolStripMenuItem;
		private Button resetButton;
		private Label label1;
		private NumericUpDown fontSize;
		private SaveFileDialog saveFile;
		private OpenFileDialog openFile;
		private PrintDialog printFile;
	}
}