﻿namespace Grupptenta2
{
	partial class ChoiceBox
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox = new System.Windows.Forms.ListBox();
			this.actionBtn = new System.Windows.Forms.Button();
			this.headerLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(4, 21);
			this.listBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(150, 147);
			this.listBox.TabIndex = 1;
			this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
			this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
			// 
			// actionBtn
			// 
			this.actionBtn.Location = new System.Drawing.Point(160, 21);
			this.actionBtn.Name = "actionBtn";
			this.actionBtn.Size = new System.Drawing.Size(75, 23);
			this.actionBtn.TabIndex = 3;
			this.actionBtn.Text = "Ändra";
			this.actionBtn.UseVisualStyleBackColor = true;
			this.actionBtn.Click += new System.EventHandler(this.editListBtn_Click);
			// 
			// headerLbl
			// 
			this.headerLbl.AutoSize = true;
			this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLbl.Location = new System.Drawing.Point(3, 3);
			this.headerLbl.Name = "headerLbl";
			this.headerLbl.Size = new System.Drawing.Size(0, 18);
			this.headerLbl.TabIndex = 32;
			// 
			// ChoiceBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.headerLbl);
			this.Controls.Add(this.actionBtn);
			this.Controls.Add(this.listBox);
			this.Name = "ChoiceBox";
			this.Size = new System.Drawing.Size(241, 175);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button actionBtn;
		private System.Windows.Forms.Label headerLbl;
        public System.Windows.Forms.ListBox listBox;
	}
}
