namespace Grupptenta2
{
	partial class CustomListBox
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
			this.headerBox = new System.Windows.Forms.TextBox();
			this.listBox = new System.Windows.Forms.ListBox();
			this.goToChoiceBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// headerBox
			// 
			this.headerBox.BackColor = System.Drawing.Color.White;
			this.headerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.headerBox.Enabled = false;
			this.headerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerBox.Location = new System.Drawing.Point(4, 3);
			this.headerBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.headerBox.Name = "headerBox";
			this.headerBox.Size = new System.Drawing.Size(150, 15);
			this.headerBox.TabIndex = 0;
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(4, 18);
			this.listBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(150, 147);
			this.listBox.TabIndex = 1;
			// 
			// goToChoiceBtn
			// 
			this.goToChoiceBtn.Location = new System.Drawing.Point(160, 18);
			this.goToChoiceBtn.Name = "goToChoiceBtn";
			this.goToChoiceBtn.Size = new System.Drawing.Size(75, 23);
			this.goToChoiceBtn.TabIndex = 2;
			this.goToChoiceBtn.Text = "Gå till";
			this.goToChoiceBtn.UseVisualStyleBackColor = true;
			this.goToChoiceBtn.Click += new System.EventHandler(this.goToChoiceBtn_Click);
			// 
			// CustomListBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.goToChoiceBtn);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.headerBox);
			this.Name = "CustomListBox";
			this.Size = new System.Drawing.Size(241, 184);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox headerBox;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Button goToChoiceBtn;
	}
}
