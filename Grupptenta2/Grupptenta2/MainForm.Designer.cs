namespace Grupptenta2
{
	partial class MainForm
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
            this.quitBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.calendarTab = new System.Windows.Forms.TabPage();
            this.projectTab = new System.Windows.Forms.TabPage();
            this.contactTab = new System.Windows.Forms.TabPage();
            this.companyTab = new System.Windows.Forms.TabPage();
            this.profileControl = new Grupptenta2.PersonUserControl();
            this.projectContainer = new System.Windows.Forms.SplitContainer();
            this.projectSearchControl = new Grupptenta2.SearchBox();
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
            this.personSearchControl = new Grupptenta2.SearchBox();
            this.personControl = new Grupptenta2.PersonUserControl();
            this.companySearchControl = new Grupptenta2.SearchBox();
            this.companyControl = new Grupptenta2.CompanyUserControl();
            this.customListBox1 = new Grupptenta2.ChoiceBox();
            this.customListBox2 = new Grupptenta2.ChoiceBox();
            this.personInfoBox1 = new Grupptenta2.PersonCreationBox();
            this.tabControl.SuspendLayout();
            this.profileTab.SuspendLayout();
            this.projectTab.SuspendLayout();
            this.contactTab.SuspendLayout();
            this.companyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectContainer)).BeginInit();
            this.projectContainer.Panel1.SuspendLayout();
            this.projectContainer.Panel2.SuspendLayout();
            this.projectContainer.SuspendLayout();
            this.projectInfoPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(1007, 12);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(101, 23);
            this.quitBtn.TabIndex = 13;
            this.quitBtn.Text = "Avsluta";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(909, 12);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(92, 23);
            this.logOutBtn.TabIndex = 12;
            this.logOutBtn.Text = "Logga ut";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.profileTab);
            this.tabControl.Controls.Add(this.calendarTab);
            this.tabControl.Controls.Add(this.projectTab);
            this.tabControl.Controls.Add(this.contactTab);
            this.tabControl.Controls.Add(this.companyTab);
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1114, 780);
            this.tabControl.TabIndex = 20;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // profileTab
            // 
            this.profileTab.Controls.Add(this.profileControl);
            this.profileTab.Location = new System.Drawing.Point(4, 22);
            this.profileTab.Name = "profileTab";
            this.profileTab.Padding = new System.Windows.Forms.Padding(3);
            this.profileTab.Size = new System.Drawing.Size(1106, 754);
            this.profileTab.TabIndex = 0;
            this.profileTab.Text = "Profil";
            this.profileTab.UseVisualStyleBackColor = true;
            // 
            // calendarTab
            // 
            this.calendarTab.Location = new System.Drawing.Point(4, 22);
            this.calendarTab.Name = "calendarTab";
            this.calendarTab.Padding = new System.Windows.Forms.Padding(3);
            this.calendarTab.Size = new System.Drawing.Size(1106, 754);
            this.calendarTab.TabIndex = 1;
            this.calendarTab.Text = "Kalender";
            this.calendarTab.UseVisualStyleBackColor = true;
            // 
            // projectTab
            // 
            this.projectTab.Controls.Add(this.projectContainer);
            this.projectTab.Location = new System.Drawing.Point(4, 22);
            this.projectTab.Name = "projectTab";
            this.projectTab.Size = new System.Drawing.Size(1106, 754);
            this.projectTab.TabIndex = 2;
            this.projectTab.Text = "Projekt";
            this.projectTab.UseVisualStyleBackColor = true;
            // 
            // contactTab
            // 
            this.contactTab.Controls.Add(this.personSearchControl);
            this.contactTab.Controls.Add(this.personControl);
            this.contactTab.Location = new System.Drawing.Point(4, 22);
            this.contactTab.Name = "contactTab";
            this.contactTab.Size = new System.Drawing.Size(1106, 754);
            this.contactTab.TabIndex = 3;
            this.contactTab.Text = "Kontakter";
            this.contactTab.UseVisualStyleBackColor = true;
            // 
            // companyTab
            // 
            this.companyTab.Controls.Add(this.companySearchControl);
            this.companyTab.Controls.Add(this.companyControl);
            this.companyTab.Location = new System.Drawing.Point(4, 22);
            this.companyTab.Name = "companyTab";
            this.companyTab.Size = new System.Drawing.Size(1106, 754);
            this.companyTab.TabIndex = 4;
            this.companyTab.Text = "Kundföretag";
            this.companyTab.UseVisualStyleBackColor = true;
            // 
            // profileControl
            // 
            this.profileControl.BackColor = System.Drawing.Color.White;
            this.profileControl.Location = new System.Drawing.Point(6, 6);
            this.profileControl.Name = "profileControl";
            this.profileControl.Size = new System.Drawing.Size(810, 574);
            this.profileControl.TabIndex = 0;
            // 
            // projectContainer
            // 
            this.projectContainer.Location = new System.Drawing.Point(0, 0);
            this.projectContainer.Name = "projectContainer";
            // 
            // projectContainer.Panel1
            // 
            this.projectContainer.Panel1.Controls.Add(this.projectSearchControl);
            // 
            // projectContainer.Panel2
            // 
            this.projectContainer.Panel2.Controls.Add(this.projectNoteBox);
            this.projectContainer.Panel2.Controls.Add(this.projectEventBox);
            this.projectContainer.Panel2.Controls.Add(this.projectParticipantBox);
            this.projectContainer.Panel2.Controls.Add(this.projectInfoPnl);
            this.projectContainer.Size = new System.Drawing.Size(1103, 712);
            this.projectContainer.SplitterDistance = 341;
            this.projectContainer.TabIndex = 10;
            // 
            // projectSearchControl
            // 
            this.projectSearchControl.Location = new System.Drawing.Point(3, 3);
            this.projectSearchControl.Name = "projectSearchControl";
            this.projectSearchControl.Size = new System.Drawing.Size(278, 301);
            this.projectSearchControl.TabIndex = 0;
            // 
            // projectNoteBox
            // 
            this.projectNoteBox.BackColor = System.Drawing.Color.White;
            this.projectNoteBox.Location = new System.Drawing.Point(293, 222);
            this.projectNoteBox.Name = "projectNoteBox";
            this.projectNoteBox.Size = new System.Drawing.Size(241, 175);
            this.projectNoteBox.TabIndex = 12;
            // 
            // projectEventBox
            // 
            this.projectEventBox.BackColor = System.Drawing.Color.White;
            this.projectEventBox.Location = new System.Drawing.Point(293, 3);
            this.projectEventBox.Name = "projectEventBox";
            this.projectEventBox.Size = new System.Drawing.Size(241, 175);
            this.projectEventBox.TabIndex = 11;
            // 
            // projectParticipantBox
            // 
            this.projectParticipantBox.BackColor = System.Drawing.Color.White;
            this.projectParticipantBox.Location = new System.Drawing.Point(9, 222);
            this.projectParticipantBox.Name = "projectParticipantBox";
            this.projectParticipantBox.Size = new System.Drawing.Size(241, 175);
            this.projectParticipantBox.TabIndex = 10;
            this.projectParticipantBox.Load += new System.EventHandler(this.projectParticipantBox_Load);
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
            this.projectInfoPnl.Location = new System.Drawing.Point(3, 3);
            this.projectInfoPnl.Name = "projectInfoPnl";
            this.projectInfoPnl.Size = new System.Drawing.Size(196, 208);
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
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
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
            // personSearchControl
            // 
            this.personSearchControl.Location = new System.Drawing.Point(3, 3);
            this.personSearchControl.Name = "personSearchControl";
            this.personSearchControl.Size = new System.Drawing.Size(278, 276);
            this.personSearchControl.TabIndex = 0;
            // 
            // personControl
            // 
            this.personControl.BackColor = System.Drawing.Color.White;
            this.personControl.Location = new System.Drawing.Point(284, 3);
            this.personControl.Name = "personControl";
            this.personControl.Size = new System.Drawing.Size(810, 574);
            this.personControl.TabIndex = 19;
            // 
            // companySearchControl
            // 
            this.companySearchControl.Location = new System.Drawing.Point(3, 3);
            this.companySearchControl.Name = "companySearchControl";
            this.companySearchControl.Size = new System.Drawing.Size(278, 276);
            this.companySearchControl.TabIndex = 0;
            // 
            // companyControl
            // 
            this.companyControl.BackColor = System.Drawing.Color.White;
            this.companyControl.Location = new System.Drawing.Point(287, 3);
            this.companyControl.Name = "companyControl";
            this.companyControl.Size = new System.Drawing.Size(810, 341);
            this.companyControl.TabIndex = 18;
            // 
            // customListBox1
            // 
            this.customListBox1.BackColor = System.Drawing.Color.White;
            this.customListBox1.Location = new System.Drawing.Point(307, 203);
            this.customListBox1.Name = "customListBox1";
            this.customListBox1.Size = new System.Drawing.Size(241, 184);
            this.customListBox1.TabIndex = 2;
            // 
            // customListBox2
            // 
            this.customListBox2.BackColor = System.Drawing.Color.White;
            this.customListBox2.Location = new System.Drawing.Point(307, 13);
            this.customListBox2.Name = "customListBox2";
            this.customListBox2.Size = new System.Drawing.Size(241, 184);
            this.customListBox2.TabIndex = 1;
            // 
            // personInfoBox1
            // 
            this.personInfoBox1.Location = new System.Drawing.Point(3, 3);
            this.personInfoBox1.Name = "personInfoBox1";
            this.personInfoBox1.Size = new System.Drawing.Size(240, 669);
            this.personInfoBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 831);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.profileTab.ResumeLayout(false);
            this.projectTab.ResumeLayout(false);
            this.contactTab.ResumeLayout(false);
            this.companyTab.ResumeLayout(false);
            this.projectContainer.Panel1.ResumeLayout(false);
            this.projectContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectContainer)).EndInit();
            this.projectContainer.ResumeLayout(false);
            this.projectInfoPnl.ResumeLayout(false);
            this.projectInfoPnl.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button quitBtn;
		private System.Windows.Forms.Button logOutBtn;
		private SearchBox personSearchControl;
		private SearchBox companySearchControl;
		private SearchBox projectSearchControl;
		private ChoiceBox customListBox1;
		private ChoiceBox customListBox2;
		private PersonCreationBox personInfoBox1;
		private CompanyUserControl companyControl;
		private PersonUserControl personControl;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage profileTab;
		private System.Windows.Forms.TabPage calendarTab;
		private System.Windows.Forms.TabPage projectTab;
		private System.Windows.Forms.TabPage contactTab;
		private System.Windows.Forms.TabPage companyTab;
		private PersonUserControl profileControl;
		private System.Windows.Forms.TextBox projectNameBox;
		private System.Windows.Forms.TextBox projectDescBox;
		private System.Windows.Forms.TextBox projectCompanyBox;
		private System.Windows.Forms.TextBox projectIdBox;
		private System.Windows.Forms.Label projectIdLbl;
		private System.Windows.Forms.Panel projectInfoPnl;
		private System.Windows.Forms.Label projectDescLbl;
		private System.Windows.Forms.Label projectCompanyLbl;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.SplitContainer projectContainer;
		private ChoiceBox projectParticipantBox;
		private ChoiceBox projectEventBox;
		private ChoiceBox projectNoteBox;
	}
}

