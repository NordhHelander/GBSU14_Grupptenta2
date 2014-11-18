namespace Grupptenta2
{
	partial class CompanyUserControl
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
			this.nameBox = new System.Windows.Forms.TextBox();
			this.idBox = new System.Windows.Forms.TextBox();
			this.streetBox = new System.Windows.Forms.TextBox();
			this.zipBox = new System.Windows.Forms.TextBox();
			this.cityBox = new System.Windows.Forms.TextBox();
			this.activeCheckBox = new System.Windows.Forms.CheckBox();
			this.idLbl = new System.Windows.Forms.Label();
			this.streetLbl = new System.Windows.Forms.Label();
			this.zipLbl = new System.Windows.Forms.Label();
			this.cityLbl = new System.Windows.Forms.Label();
			this.saveBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nameBox
			// 
			this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameBox.Location = new System.Drawing.Point(3, 3);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(178, 26);
			this.nameBox.TabIndex = 0;
			// 
			// idBox
			// 
			this.idBox.Location = new System.Drawing.Point(81, 35);
			this.idBox.Name = "idBox";
			this.idBox.Size = new System.Drawing.Size(100, 20);
			this.idBox.TabIndex = 1;
			// 
			// streetBox
			// 
			this.streetBox.Location = new System.Drawing.Point(81, 61);
			this.streetBox.Name = "streetBox";
			this.streetBox.Size = new System.Drawing.Size(100, 20);
			this.streetBox.TabIndex = 2;
			// 
			// zipBox
			// 
			this.zipBox.Location = new System.Drawing.Point(81, 87);
			this.zipBox.Name = "zipBox";
			this.zipBox.Size = new System.Drawing.Size(100, 20);
			this.zipBox.TabIndex = 3;
			// 
			// cityBox
			// 
			this.cityBox.Location = new System.Drawing.Point(81, 113);
			this.cityBox.Name = "cityBox";
			this.cityBox.Size = new System.Drawing.Size(100, 20);
			this.cityBox.TabIndex = 4;
			// 
			// activeCheckBox
			// 
			this.activeCheckBox.AutoSize = true;
			this.activeCheckBox.Location = new System.Drawing.Point(81, 139);
			this.activeCheckBox.Name = "activeCheckBox";
			this.activeCheckBox.Size = new System.Drawing.Size(53, 17);
			this.activeCheckBox.TabIndex = 5;
			this.activeCheckBox.Text = "Aktivt";
			this.activeCheckBox.UseVisualStyleBackColor = true;
			// 
			// idLbl
			// 
			this.idLbl.AutoSize = true;
			this.idLbl.Location = new System.Drawing.Point(0, 38);
			this.idLbl.Name = "idLbl";
			this.idLbl.Size = new System.Drawing.Size(56, 13);
			this.idLbl.TabIndex = 6;
			this.idLbl.Text = "Företagsid";
			// 
			// streetLbl
			// 
			this.streetLbl.AutoSize = true;
			this.streetLbl.Location = new System.Drawing.Point(0, 64);
			this.streetLbl.Name = "streetLbl";
			this.streetLbl.Size = new System.Drawing.Size(61, 13);
			this.streetLbl.TabIndex = 7;
			this.streetLbl.Text = "Gatuadress";
			// 
			// zipLbl
			// 
			this.zipLbl.AutoSize = true;
			this.zipLbl.Location = new System.Drawing.Point(0, 90);
			this.zipLbl.Name = "zipLbl";
			this.zipLbl.Size = new System.Drawing.Size(65, 13);
			this.zipLbl.TabIndex = 8;
			this.zipLbl.Text = "Postnummer";
			// 
			// cityLbl
			// 
			this.cityLbl.AutoSize = true;
			this.cityLbl.Location = new System.Drawing.Point(0, 116);
			this.cityLbl.Name = "cityLbl";
			this.cityLbl.Size = new System.Drawing.Size(40, 13);
			this.cityLbl.TabIndex = 9;
			this.cityLbl.Text = "Postort";
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(64, 277);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(117, 23);
			this.saveBtn.TabIndex = 11;
			this.saveBtn.Text = "Spara";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// CompanyUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.cityLbl);
			this.Controls.Add(this.zipLbl);
			this.Controls.Add(this.streetLbl);
			this.Controls.Add(this.idLbl);
			this.Controls.Add(this.activeCheckBox);
			this.Controls.Add(this.cityBox);
			this.Controls.Add(this.zipBox);
			this.Controls.Add(this.streetBox);
			this.Controls.Add(this.idBox);
			this.Controls.Add(this.nameBox);
			this.Name = "CompanyUserControl";
			this.Size = new System.Drawing.Size(189, 310);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.TextBox idBox;
		private System.Windows.Forms.TextBox streetBox;
		private System.Windows.Forms.TextBox zipBox;
		private System.Windows.Forms.TextBox cityBox;
		private System.Windows.Forms.CheckBox activeCheckBox;
		private System.Windows.Forms.Label idLbl;
		private System.Windows.Forms.Label streetLbl;
		private System.Windows.Forms.Label zipLbl;
		private System.Windows.Forms.Label cityLbl;
		private System.Windows.Forms.Button saveBtn;
	}
}
