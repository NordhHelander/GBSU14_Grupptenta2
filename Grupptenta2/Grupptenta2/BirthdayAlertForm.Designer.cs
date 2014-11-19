namespace Grupptenta2
{
	partial class BirthdayAlertForm
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
			this.birthdayList = new System.Windows.Forms.ListBox();
			this.headerLbl = new System.Windows.Forms.Label();
			this.nameTurnsAgeLbl = new System.Windows.Forms.Label();
			this.closeBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// birthdayList
			// 
			this.birthdayList.FormattingEnabled = true;
			this.birthdayList.Location = new System.Drawing.Point(16, 32);
			this.birthdayList.Name = "birthdayList";
			this.birthdayList.Size = new System.Drawing.Size(161, 173);
			this.birthdayList.TabIndex = 0;
			this.birthdayList.SelectedIndexChanged += new System.EventHandler(this.birthdayList_SelectedIndexChanged);
			// 
			// headerLbl
			// 
			this.headerLbl.AutoSize = true;
			this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLbl.Location = new System.Drawing.Point(12, 9);
			this.headerLbl.Name = "headerLbl";
			this.headerLbl.Size = new System.Drawing.Size(133, 20);
			this.headerLbl.TabIndex = 1;
			this.headerLbl.Text = "Födelsedagsbarn";
			// 
			// nameTurnsAgeLbl
			// 
			this.nameTurnsAgeLbl.AutoSize = true;
			this.nameTurnsAgeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameTurnsAgeLbl.Location = new System.Drawing.Point(16, 212);
			this.nameTurnsAgeLbl.MaximumSize = new System.Drawing.Size(160, 58);
			this.nameTurnsAgeLbl.Name = "nameTurnsAgeLbl";
			this.nameTurnsAgeLbl.Size = new System.Drawing.Size(0, 13);
			this.nameTurnsAgeLbl.TabIndex = 2;
			// 
			// closeBtn
			// 
			this.closeBtn.Location = new System.Drawing.Point(100, 270);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(75, 23);
			this.closeBtn.TabIndex = 3;
			this.closeBtn.Text = "Stäng";
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// BirthdayAlertForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(194, 303);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.nameTurnsAgeLbl);
			this.Controls.Add(this.headerLbl);
			this.Controls.Add(this.birthdayList);
			this.Name = "BirthdayAlertForm";
			this.Text = "BirthdayAlertForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox birthdayList;
		private System.Windows.Forms.Label headerLbl;
		private System.Windows.Forms.Label nameTurnsAgeLbl;
		private System.Windows.Forms.Button closeBtn;
	}
}