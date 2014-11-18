namespace Grupptenta2
{
	partial class ProjectPopUp
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
			this.projectNoteBox = new Grupptenta2.ChoiceBox();
			this.projectEventBox = new Grupptenta2.ChoiceBox();
			this.projectParticipantBox = new Grupptenta2.ChoiceBox();
			this.projectInfoPnl = new System.Windows.Forms.Panel();
			this.saveBtn = new System.Windows.Forms.Button();
			this.projectDescLbl = new System.Windows.Forms.Label();
			this.projectCompanyLbl = new System.Windows.Forms.Label();
			this.projectNameBox = new System.Windows.Forms.TextBox();
			this.projectIdLbl = new System.Windows.Forms.Label();
			this.projectIdBox = new System.Windows.Forms.TextBox();
			this.projectDescBox = new System.Windows.Forms.TextBox();
			this.projectCompanyBox = new System.Windows.Forms.TextBox();
			this.projectInfoPnl.SuspendLayout();
			this.SuspendLayout();
			// 
			// projectNoteBox
			// 
			this.projectNoteBox.BackColor = System.Drawing.Color.White;
			this.projectNoteBox.Location = new System.Drawing.Point(262, 288);
			this.projectNoteBox.Name = "projectNoteBox";
			this.projectNoteBox.Size = new System.Drawing.Size(241, 186);
			this.projectNoteBox.TabIndex = 12;
			// 
			// projectEventBox
			// 
			this.projectEventBox.BackColor = System.Drawing.Color.White;
			this.projectEventBox.Location = new System.Drawing.Point(262, 12);
			this.projectEventBox.Name = "projectEventBox";
			this.projectEventBox.Size = new System.Drawing.Size(241, 219);
			this.projectEventBox.TabIndex = 11;
			// 
			// projectParticipantBox
			// 
			this.projectParticipantBox.BackColor = System.Drawing.Color.White;
			this.projectParticipantBox.Location = new System.Drawing.Point(12, 288);
			this.projectParticipantBox.Name = "projectParticipantBox";
			this.projectParticipantBox.Size = new System.Drawing.Size(241, 186);
			this.projectParticipantBox.TabIndex = 10;
			// 
			// projectInfoPnl
			// 
			this.projectInfoPnl.Controls.Add(this.saveBtn);
			this.projectInfoPnl.Controls.Add(this.projectDescLbl);
			this.projectInfoPnl.Controls.Add(this.projectCompanyLbl);
			this.projectInfoPnl.Controls.Add(this.projectNameBox);
			this.projectInfoPnl.Controls.Add(this.projectIdLbl);
			this.projectInfoPnl.Controls.Add(this.projectIdBox);
			this.projectInfoPnl.Controls.Add(this.projectDescBox);
			this.projectInfoPnl.Controls.Add(this.projectCompanyBox);
			this.projectInfoPnl.Location = new System.Drawing.Point(12, 12);
			this.projectInfoPnl.Name = "projectInfoPnl";
			this.projectInfoPnl.Size = new System.Drawing.Size(196, 252);
			this.projectInfoPnl.TabIndex = 9;
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(89, 181);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(100, 23);
			this.saveBtn.TabIndex = 11;
			this.saveBtn.Text = "Spara ändringar";
			this.saveBtn.UseVisualStyleBackColor = true;
			// 
			// projectDescLbl
			// 
			this.projectDescLbl.AutoSize = true;
			this.projectDescLbl.Location = new System.Drawing.Point(3, 90);
			this.projectDescLbl.Name = "projectDescLbl";
			this.projectDescLbl.Size = new System.Drawing.Size(62, 13);
			this.projectDescLbl.TabIndex = 10;
			this.projectDescLbl.Text = "Beskrivning";
			// 
			// projectCompanyLbl
			// 
			this.projectCompanyLbl.AutoSize = true;
			this.projectCompanyLbl.Location = new System.Drawing.Point(3, 64);
			this.projectCompanyLbl.Name = "projectCompanyLbl";
			this.projectCompanyLbl.Size = new System.Drawing.Size(43, 13);
			this.projectCompanyLbl.TabIndex = 9;
			this.projectCompanyLbl.Text = "Företag";
			// 
			// projectNameBox
			// 
			this.projectNameBox.BackColor = System.Drawing.Color.White;
			this.projectNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.projectNameBox.Location = new System.Drawing.Point(3, 3);
			this.projectNameBox.Name = "projectNameBox";
			this.projectNameBox.Size = new System.Drawing.Size(186, 26);
			this.projectNameBox.TabIndex = 4;
			// 
			// projectIdLbl
			// 
			this.projectIdLbl.AutoSize = true;
			this.projectIdLbl.Location = new System.Drawing.Point(3, 38);
			this.projectIdLbl.Name = "projectIdLbl";
			this.projectIdLbl.Size = new System.Drawing.Size(49, 13);
			this.projectIdLbl.TabIndex = 8;
			this.projectIdLbl.Text = "ProjektId";
			// 
			// projectIdBox
			// 
			this.projectIdBox.BackColor = System.Drawing.Color.White;
			this.projectIdBox.Location = new System.Drawing.Point(89, 35);
			this.projectIdBox.Name = "projectIdBox";
			this.projectIdBox.ReadOnly = true;
			this.projectIdBox.Size = new System.Drawing.Size(100, 20);
			this.projectIdBox.TabIndex = 5;
			// 
			// projectDescBox
			// 
			this.projectDescBox.BackColor = System.Drawing.Color.White;
			this.projectDescBox.Location = new System.Drawing.Point(89, 87);
			this.projectDescBox.Multiline = true;
			this.projectDescBox.Name = "projectDescBox";
			this.projectDescBox.Size = new System.Drawing.Size(100, 87);
			this.projectDescBox.TabIndex = 7;
			// 
			// projectCompanyBox
			// 
			this.projectCompanyBox.BackColor = System.Drawing.Color.White;
			this.projectCompanyBox.Location = new System.Drawing.Point(89, 61);
			this.projectCompanyBox.Name = "projectCompanyBox";
			this.projectCompanyBox.ReadOnly = true;
			this.projectCompanyBox.Size = new System.Drawing.Size(100, 20);
			this.projectCompanyBox.TabIndex = 6;
			// 
			// ProjectPopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(521, 504);
			this.Controls.Add(this.projectNoteBox);
			this.Controls.Add(this.projectEventBox);
			this.Controls.Add(this.projectInfoPnl);
			this.Controls.Add(this.projectParticipantBox);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Name = "ProjectPopUp";
			this.Text = "ProjectPopUp";
			this.projectInfoPnl.ResumeLayout(false);
			this.projectInfoPnl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ChoiceBox projectNoteBox;
		private ChoiceBox projectEventBox;
		private ChoiceBox projectParticipantBox;
		private System.Windows.Forms.Panel projectInfoPnl;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Label projectDescLbl;
		private System.Windows.Forms.Label projectCompanyLbl;
		private System.Windows.Forms.TextBox projectNameBox;
		private System.Windows.Forms.Label projectIdLbl;
		private System.Windows.Forms.TextBox projectIdBox;
		private System.Windows.Forms.TextBox projectDescBox;
		private System.Windows.Forms.TextBox projectCompanyBox;
	}
}