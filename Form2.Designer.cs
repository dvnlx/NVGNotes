﻿namespace NVGNotes
{
	partial class Form2
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
			label1 = new Label();
			label2 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Albert Sans", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(58, 42);
			label1.Name = "label1";
			label1.Size = new Size(176, 45);
			label1.TabIndex = 0;
			label1.Text = "NVGNotes";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(58, 87);
			label2.Name = "label2";
			label2.Size = new Size(52, 15);
			label2.TabIndex = 1;
			label2.Text = "by dvnlx";
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(299, 149);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			Name = "Form2";
			Text = "About";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
	}
}