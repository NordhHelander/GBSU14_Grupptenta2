namespace Grupptenta2
{
	partial class NoteForm
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
			this.dateTimeLbl = new System.Windows.Forms.Label();
			this.authorLbl = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.TextBox();
			this.closeBtn = new System.Windows.Forms.Button();
			this.dateTimeBox = new System.Windows.Forms.TextBox();
			this.authorBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// dateTimeLbl
			// 
			this.dateTimeLbl.AutoSize = true;
			this.dateTimeLbl.Location = new System.Drawing.Point(13, 13);
			this.dateTimeLbl.Name = "dateTimeLbl";
			this.dateTimeLbl.Size = new System.Drawing.Size(44, 13);
			this.dateTimeLbl.TabIndex = 0;
			this.dateTimeLbl.Text = "Datum: ";
			// 
			// authorLbl
			// 
			this.authorLbl.AutoSize = true;
			this.authorLbl.Location = new System.Drawing.Point(12, 31);
			this.authorLbl.Name = "authorLbl";
			this.authorLbl.Size = new System.Drawing.Size(61, 13);
			this.authorLbl.TabIndex = 1;
			this.authorLbl.Text = "Skriven av:";
			// 
			// textBox
			// 
			this.textBox.BackColor = System.Drawing.Color.White;
			this.textBox.Location = new System.Drawing.Point(16, 57);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.ReadOnly = true;
			this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox.Size = new System.Drawing.Size(212, 106);
			this.textBox.TabIndex = 4;
			// 
			// closeBtn
			// 
			this.closeBtn.Location = new System.Drawing.Point(153, 169);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(75, 23);
			this.closeBtn.TabIndex = 5;
			this.closeBtn.Text = "Stäng";
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// dateTimeBox
			// 
			this.dateTimeBox.BackColor = System.Drawing.Color.White;
			this.dateTimeBox.Location = new System.Drawing.Point(79, 5);
			this.dateTimeBox.Name = "dateTimeBox";
			this.dateTimeBox.ReadOnly = true;
			this.dateTimeBox.Size = new System.Drawing.Size(149, 20);
			this.dateTimeBox.TabIndex = 6;
			// 
			// authorBox
			// 
			this.authorBox.BackColor = System.Drawing.Color.White;
			this.authorBox.Location = new System.Drawing.Point(79, 31);
			this.authorBox.Name = "authorBox";
			this.authorBox.ReadOnly = true;
			this.authorBox.Size = new System.Drawing.Size(149, 20);
			this.authorBox.TabIndex = 7;
			// 
			// NoteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(240, 205);
			this.Controls.Add(this.authorBox);
			this.Controls.Add(this.dateTimeBox);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.authorLbl);
			this.Controls.Add(this.dateTimeLbl);
			this.Name = "NoteForm";
			this.Text = "NoteForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label dateTimeLbl;
		private System.Windows.Forms.Label authorLbl;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.TextBox dateTimeBox;
		private System.Windows.Forms.TextBox authorBox;
	}
}