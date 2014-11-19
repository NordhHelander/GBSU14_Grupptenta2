﻿namespace Grupptenta2
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
			this.companyTab = new System.Windows.Forms.TabPage();
			this.companyContainer = new System.Windows.Forms.SplitContainer();
			this.companyChoiceBox = new Grupptenta2.ChoiceBox();
			this.companyEmployeeBox = new Grupptenta2.ChoiceBox();
			this.companyProjectBox = new Grupptenta2.ChoiceBox();
			this.companyControl = new Grupptenta2.CompanyUserControl();
			this.contactTab = new System.Windows.Forms.TabPage();
			this.contactContainer = new System.Windows.Forms.SplitContainer();
			this.contactChoiceBox = new Grupptenta2.ChoiceBox();
			this.contactControl = new Grupptenta2.PersonUserControl();
			this.contactRelationBox = new Grupptenta2.ChoiceBox();
			this.contactProjectBox = new Grupptenta2.ChoiceBox();
			this.projectTab = new System.Windows.Forms.TabPage();
			this.projectContainer = new System.Windows.Forms.SplitContainer();
			this.projectChoiceBox = new Grupptenta2.ChoiceBox();
			this.projectAvailableParticipantsBox = new Grupptenta2.ChoiceBox();
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
			this.calendarTab = new System.Windows.Forms.TabPage();
			this.eventListLbl = new System.Windows.Forms.Label();
			this.eventListBox = new System.Windows.Forms.ListBox();
			this.pickDateLbl = new System.Windows.Forms.Label();
			this.createEventBtn = new System.Windows.Forms.Button();
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.customListBox1 = new Grupptenta2.ChoiceBox();
			this.customListBox2 = new Grupptenta2.ChoiceBox();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.eventProjectBox = new System.Windows.Forms.TextBox();
			this.eventCompanyBox = new System.Windows.Forms.TextBox();
			this.eventProjectLbl = new System.Windows.Forms.Label();
			this.eventCompanyLbl = new System.Windows.Forms.Label();
			this.startDatetimeLbl = new System.Windows.Forms.Label();
			this.stopDateTimeLbl = new System.Windows.Forms.Label();
			this.eventNoteBox = new System.Windows.Forms.ListBox();
			this.eventNotesLbl = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.eventAddNoteBox = new System.Windows.Forms.TextBox();
			this.eventAddNoteLbl = new System.Windows.Forms.Label();
			this.eventAddNoteBtn = new System.Windows.Forms.Button();
			this.eventIsMeetingCheckBox = new System.Windows.Forms.CheckBox();
			this.companyTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.companyContainer)).BeginInit();
			this.companyContainer.Panel1.SuspendLayout();
			this.companyContainer.Panel2.SuspendLayout();
			this.companyContainer.SuspendLayout();
			this.contactTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.contactContainer)).BeginInit();
			this.contactContainer.Panel1.SuspendLayout();
			this.contactContainer.Panel2.SuspendLayout();
			this.contactContainer.SuspendLayout();
			this.projectTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.projectContainer)).BeginInit();
			this.projectContainer.Panel1.SuspendLayout();
			this.projectContainer.Panel2.SuspendLayout();
			this.projectContainer.SuspendLayout();
			this.projectInfoPnl.SuspendLayout();
			this.calendarTab.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.panel1.SuspendLayout();
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
			// companyTab
			// 
			this.companyTab.Controls.Add(this.companyContainer);
			this.companyTab.Location = new System.Drawing.Point(4, 22);
			this.companyTab.Name = "companyTab";
			this.companyTab.Size = new System.Drawing.Size(1106, 754);
			this.companyTab.TabIndex = 4;
			this.companyTab.Text = "Kundföretag";
			this.companyTab.UseVisualStyleBackColor = true;
			// 
			// companyContainer
			// 
			this.companyContainer.Location = new System.Drawing.Point(0, 0);
			this.companyContainer.Name = "companyContainer";
			// 
			// companyContainer.Panel1
			// 
			this.companyContainer.Panel1.Controls.Add(this.companyChoiceBox);
			// 
			// companyContainer.Panel2
			// 
			this.companyContainer.Panel2.Controls.Add(this.companyEmployeeBox);
			this.companyContainer.Panel2.Controls.Add(this.companyProjectBox);
			this.companyContainer.Panel2.Controls.Add(this.companyControl);
			this.companyContainer.Size = new System.Drawing.Size(1103, 712);
			this.companyContainer.SplitterDistance = 341;
			this.companyContainer.TabIndex = 19;
			// 
			// companyChoiceBox
			// 
			this.companyChoiceBox.BackColor = System.Drawing.Color.White;
			this.companyChoiceBox.Location = new System.Drawing.Point(0, 0);
			this.companyChoiceBox.Name = "companyChoiceBox";
			this.companyChoiceBox.Size = new System.Drawing.Size(241, 175);
			this.companyChoiceBox.TabIndex = 1;
			// 
			// companyEmployeeBox
			// 
			this.companyEmployeeBox.BackColor = System.Drawing.Color.White;
			this.companyEmployeeBox.Location = new System.Drawing.Point(259, 228);
			this.companyEmployeeBox.Name = "companyEmployeeBox";
			this.companyEmployeeBox.Size = new System.Drawing.Size(241, 175);
			this.companyEmployeeBox.TabIndex = 2;
			// 
			// companyProjectBox
			// 
			this.companyProjectBox.BackColor = System.Drawing.Color.White;
			this.companyProjectBox.Location = new System.Drawing.Point(259, 16);
			this.companyProjectBox.Name = "companyProjectBox";
			this.companyProjectBox.Size = new System.Drawing.Size(241, 175);
			this.companyProjectBox.TabIndex = 1;
			// 
			// companyControl
			// 
			this.companyControl.BackColor = System.Drawing.Color.White;
			this.companyControl.Location = new System.Drawing.Point(12, 16);
			this.companyControl.Name = "companyControl";
			this.companyControl.Size = new System.Drawing.Size(189, 310);
			this.companyControl.TabIndex = 0;
			// 
			// contactTab
			// 
			this.contactTab.Controls.Add(this.contactContainer);
			this.contactTab.Location = new System.Drawing.Point(4, 22);
			this.contactTab.Name = "contactTab";
			this.contactTab.Size = new System.Drawing.Size(1106, 754);
			this.contactTab.TabIndex = 3;
			this.contactTab.Text = "Kontakter";
			this.contactTab.UseVisualStyleBackColor = true;
			// 
			// contactContainer
			// 
			this.contactContainer.Location = new System.Drawing.Point(0, 0);
			this.contactContainer.Name = "contactContainer";
			// 
			// contactContainer.Panel1
			// 
			this.contactContainer.Panel1.Controls.Add(this.contactChoiceBox);
			// 
			// contactContainer.Panel2
			// 
			this.contactContainer.Panel2.Controls.Add(this.contactControl);
			this.contactContainer.Panel2.Controls.Add(this.contactRelationBox);
			this.contactContainer.Panel2.Controls.Add(this.contactProjectBox);
			this.contactContainer.Size = new System.Drawing.Size(1103, 712);
			this.contactContainer.SplitterDistance = 341;
			this.contactContainer.TabIndex = 11;
			// 
			// contactChoiceBox
			// 
			this.contactChoiceBox.BackColor = System.Drawing.Color.White;
			this.contactChoiceBox.Location = new System.Drawing.Point(0, 0);
			this.contactChoiceBox.Name = "contactChoiceBox";
			this.contactChoiceBox.Size = new System.Drawing.Size(241, 175);
			this.contactChoiceBox.TabIndex = 1;
			// 
			// contactControl
			// 
			this.contactControl.BackColor = System.Drawing.Color.White;
			this.contactControl.Location = new System.Drawing.Point(3, 13);
			this.contactControl.Name = "contactControl";
			this.contactControl.Size = new System.Drawing.Size(481, 485);
			this.contactControl.TabIndex = 13;
			// 
			// contactRelationBox
			// 
			this.contactRelationBox.BackColor = System.Drawing.Color.White;
			this.contactRelationBox.Location = new System.Drawing.Point(490, 13);
			this.contactRelationBox.Name = "contactRelationBox";
			this.contactRelationBox.Size = new System.Drawing.Size(241, 175);
			this.contactRelationBox.TabIndex = 12;
			// 
			// contactProjectBox
			// 
			this.contactProjectBox.BackColor = System.Drawing.Color.White;
			this.contactProjectBox.Location = new System.Drawing.Point(490, 239);
			this.contactProjectBox.Name = "contactProjectBox";
			this.contactProjectBox.Size = new System.Drawing.Size(241, 175);
			this.contactProjectBox.TabIndex = 10;
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
			// projectContainer
			// 
			this.projectContainer.Location = new System.Drawing.Point(0, 0);
			this.projectContainer.Name = "projectContainer";
			// 
			// projectContainer.Panel1
			// 
			this.projectContainer.Panel1.Controls.Add(this.projectChoiceBox);
			// 
			// projectContainer.Panel2
			// 
			this.projectContainer.Panel2.Controls.Add(this.projectAvailableParticipantsBox);
			this.projectContainer.Panel2.Controls.Add(this.projectNoteBox);
			this.projectContainer.Panel2.Controls.Add(this.projectEventBox);
			this.projectContainer.Panel2.Controls.Add(this.projectParticipantBox);
			this.projectContainer.Panel2.Controls.Add(this.projectInfoPnl);
			this.projectContainer.Size = new System.Drawing.Size(1103, 712);
			this.projectContainer.SplitterDistance = 341;
			this.projectContainer.TabIndex = 10;
			// 
			// projectChoiceBox
			// 
			this.projectChoiceBox.BackColor = System.Drawing.Color.White;
			this.projectChoiceBox.Location = new System.Drawing.Point(0, 0);
			this.projectChoiceBox.Name = "projectChoiceBox";
			this.projectChoiceBox.Size = new System.Drawing.Size(241, 175);
			this.projectChoiceBox.TabIndex = 1;
			// 
			// projectAvailableParticipantsBox
			// 
			this.projectAvailableParticipantsBox.BackColor = System.Drawing.Color.White;
			this.projectAvailableParticipantsBox.Location = new System.Drawing.Point(9, 413);
			this.projectAvailableParticipantsBox.Name = "projectAvailableParticipantsBox";
			this.projectAvailableParticipantsBox.Size = new System.Drawing.Size(241, 175);
			this.projectAvailableParticipantsBox.TabIndex = 13;
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
			this.saveBtn.Text = "Spara";
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
			// calendarTab
			// 
			this.calendarTab.Controls.Add(this.panel1);
			this.calendarTab.Controls.Add(this.eventListLbl);
			this.calendarTab.Controls.Add(this.eventListBox);
			this.calendarTab.Controls.Add(this.pickDateLbl);
			this.calendarTab.Controls.Add(this.createEventBtn);
			this.calendarTab.Controls.Add(this.monthCalendar);
			this.calendarTab.Location = new System.Drawing.Point(4, 22);
			this.calendarTab.Name = "calendarTab";
			this.calendarTab.Padding = new System.Windows.Forms.Padding(3);
			this.calendarTab.Size = new System.Drawing.Size(1106, 754);
			this.calendarTab.TabIndex = 1;
			this.calendarTab.Text = "Kalender";
			this.calendarTab.UseVisualStyleBackColor = true;
			// 
			// eventListLbl
			// 
			this.eventListLbl.AutoSize = true;
			this.eventListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eventListLbl.Location = new System.Drawing.Point(10, 229);
			this.eventListLbl.Name = "eventListLbl";
			this.eventListLbl.Size = new System.Drawing.Size(82, 20);
			this.eventListLbl.TabIndex = 5;
			this.eventListLbl.Text = "Händelser";
			// 
			// eventListBox
			// 
			this.eventListBox.FormattingEnabled = true;
			this.eventListBox.Location = new System.Drawing.Point(14, 252);
			this.eventListBox.Name = "eventListBox";
			this.eventListBox.Size = new System.Drawing.Size(242, 355);
			this.eventListBox.TabIndex = 4;
			// 
			// pickDateLbl
			// 
			this.pickDateLbl.AutoSize = true;
			this.pickDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickDateLbl.Location = new System.Drawing.Point(9, 15);
			this.pickDateLbl.Name = "pickDateLbl";
			this.pickDateLbl.Size = new System.Drawing.Size(84, 20);
			this.pickDateLbl.TabIndex = 3;
			this.pickDateLbl.Text = "Välj datum";
			// 
			// createEventBtn
			// 
			this.createEventBtn.Location = new System.Drawing.Point(268, 613);
			this.createEventBtn.Name = "createEventBtn";
			this.createEventBtn.Size = new System.Drawing.Size(115, 23);
			this.createEventBtn.TabIndex = 2;
			this.createEventBtn.Text = "Skapa händelse";
			this.createEventBtn.UseVisualStyleBackColor = true;
			// 
			// monthCalendar
			// 
			this.monthCalendar.BackColor = System.Drawing.Color.White;
			this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
			this.monthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monthCalendar.Location = new System.Drawing.Point(14, 44);
			this.monthCalendar.MaxSelectionCount = 1;
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.ShowToday = false;
			this.monthCalendar.ShowWeekNumbers = true;
			this.monthCalendar.TabIndex = 0;
			this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
			// 
			// tabControl
			// 
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
			// nameBox
			// 
			this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameBox.Location = new System.Drawing.Point(6, 3);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(200, 26);
			this.nameBox.TabIndex = 0;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(6, 117);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker.TabIndex = 1;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(6, 155);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 2;
			// 
			// eventProjectBox
			// 
			this.eventProjectBox.Location = new System.Drawing.Point(65, 35);
			this.eventProjectBox.Name = "eventProjectBox";
			this.eventProjectBox.Size = new System.Drawing.Size(141, 20);
			this.eventProjectBox.TabIndex = 3;
			// 
			// eventCompanyBox
			// 
			this.eventCompanyBox.Location = new System.Drawing.Point(65, 61);
			this.eventCompanyBox.Name = "eventCompanyBox";
			this.eventCompanyBox.Size = new System.Drawing.Size(141, 20);
			this.eventCompanyBox.TabIndex = 4;
			// 
			// eventProjectLbl
			// 
			this.eventProjectLbl.AutoSize = true;
			this.eventProjectLbl.Location = new System.Drawing.Point(3, 38);
			this.eventProjectLbl.Name = "eventProjectLbl";
			this.eventProjectLbl.Size = new System.Drawing.Size(43, 13);
			this.eventProjectLbl.TabIndex = 5;
			this.eventProjectLbl.Text = "Projekt:";
			this.eventProjectLbl.Click += new System.EventHandler(this.label1_Click);
			// 
			// eventCompanyLbl
			// 
			this.eventCompanyLbl.AutoSize = true;
			this.eventCompanyLbl.Location = new System.Drawing.Point(3, 64);
			this.eventCompanyLbl.Name = "eventCompanyLbl";
			this.eventCompanyLbl.Size = new System.Drawing.Size(46, 13);
			this.eventCompanyLbl.TabIndex = 6;
			this.eventCompanyLbl.Text = "Företag:";
			this.eventCompanyLbl.Click += new System.EventHandler(this.label2_Click);
			// 
			// startDatetimeLbl
			// 
			this.startDatetimeLbl.AutoSize = true;
			this.startDatetimeLbl.Location = new System.Drawing.Point(3, 101);
			this.startDatetimeLbl.Name = "startDatetimeLbl";
			this.startDatetimeLbl.Size = new System.Drawing.Size(31, 13);
			this.startDatetimeLbl.TabIndex = 7;
			this.startDatetimeLbl.Text = "Från:";
			// 
			// stopDateTimeLbl
			// 
			this.stopDateTimeLbl.AutoSize = true;
			this.stopDateTimeLbl.Location = new System.Drawing.Point(3, 140);
			this.stopDateTimeLbl.Name = "stopDateTimeLbl";
			this.stopDateTimeLbl.Size = new System.Drawing.Size(23, 13);
			this.stopDateTimeLbl.TabIndex = 8;
			this.stopDateTimeLbl.Text = "Till:";
			// 
			// eventNoteBox
			// 
			this.eventNoteBox.FormattingEnabled = true;
			this.eventNoteBox.Location = new System.Drawing.Point(7, 221);
			this.eventNoteBox.Name = "eventNoteBox";
			this.eventNoteBox.Size = new System.Drawing.Size(200, 95);
			this.eventNoteBox.TabIndex = 9;
			// 
			// eventNotesLbl
			// 
			this.eventNotesLbl.AutoSize = true;
			this.eventNotesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eventNotesLbl.Location = new System.Drawing.Point(3, 198);
			this.eventNotesLbl.Name = "eventNotesLbl";
			this.eventNotesLbl.Size = new System.Drawing.Size(103, 20);
			this.eventNotesLbl.TabIndex = 10;
			this.eventNotesLbl.Text = "Anteckningar";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.eventIsMeetingCheckBox);
			this.panel1.Controls.Add(this.eventAddNoteBtn);
			this.panel1.Controls.Add(this.eventAddNoteLbl);
			this.panel1.Controls.Add(this.eventAddNoteBox);
			this.panel1.Controls.Add(this.eventNoteBox);
			this.panel1.Controls.Add(this.eventNotesLbl);
			this.panel1.Controls.Add(this.nameBox);
			this.panel1.Controls.Add(this.eventProjectBox);
			this.panel1.Controls.Add(this.stopDateTimeLbl);
			this.panel1.Controls.Add(this.eventCompanyBox);
			this.panel1.Controls.Add(this.startDatetimeLbl);
			this.panel1.Controls.Add(this.eventProjectLbl);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.dateTimePicker);
			this.panel1.Controls.Add(this.eventCompanyLbl);
			this.panel1.Location = new System.Drawing.Point(268, 53);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(670, 554);
			this.panel1.TabIndex = 8;
			// 
			// eventAddNoteBox
			// 
			this.eventAddNoteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.eventAddNoteBox.Location = new System.Drawing.Point(6, 392);
			this.eventAddNoteBox.Multiline = true;
			this.eventAddNoteBox.Name = "eventAddNoteBox";
			this.eventAddNoteBox.Size = new System.Drawing.Size(200, 95);
			this.eventAddNoteBox.TabIndex = 11;
			// 
			// eventAddNoteLbl
			// 
			this.eventAddNoteLbl.AutoSize = true;
			this.eventAddNoteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eventAddNoteLbl.Location = new System.Drawing.Point(3, 369);
			this.eventAddNoteLbl.Name = "eventAddNoteLbl";
			this.eventAddNoteLbl.Size = new System.Drawing.Size(109, 20);
			this.eventAddNoteLbl.TabIndex = 12;
			this.eventAddNoteLbl.Text = "Ny anteckning";
			// 
			// eventAddNoteBtn
			// 
			this.eventAddNoteBtn.Location = new System.Drawing.Point(131, 493);
			this.eventAddNoteBtn.Name = "eventAddNoteBtn";
			this.eventAddNoteBtn.Size = new System.Drawing.Size(75, 23);
			this.eventAddNoteBtn.TabIndex = 14;
			this.eventAddNoteBtn.Text = "Lägg till";
			this.eventAddNoteBtn.UseVisualStyleBackColor = true;
			// 
			// eventIsMeetingCheckBox
			// 
			this.eventIsMeetingCheckBox.AutoSize = true;
			this.eventIsMeetingCheckBox.Location = new System.Drawing.Point(65, 88);
			this.eventIsMeetingCheckBox.Name = "eventIsMeetingCheckBox";
			this.eventIsMeetingCheckBox.Size = new System.Drawing.Size(50, 17);
			this.eventIsMeetingCheckBox.TabIndex = 15;
			this.eventIsMeetingCheckBox.Text = "Möte";
			this.eventIsMeetingCheckBox.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1125, 831);
			this.Controls.Add(this.quitBtn);
			this.Controls.Add(this.tabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "Form1";
			this.companyTab.ResumeLayout(false);
			this.companyContainer.Panel1.ResumeLayout(false);
			this.companyContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.companyContainer)).EndInit();
			this.companyContainer.ResumeLayout(false);
			this.contactTab.ResumeLayout(false);
			this.contactContainer.Panel1.ResumeLayout(false);
			this.contactContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.contactContainer)).EndInit();
			this.contactContainer.ResumeLayout(false);
			this.projectTab.ResumeLayout(false);
			this.projectContainer.Panel1.ResumeLayout(false);
			this.projectContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.projectContainer)).EndInit();
			this.projectContainer.ResumeLayout(false);
			this.projectInfoPnl.ResumeLayout(false);
			this.projectInfoPnl.PerformLayout();
			this.calendarTab.ResumeLayout(false);
			this.calendarTab.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button quitBtn;
		private ChoiceBox customListBox1;
		private ChoiceBox customListBox2;
		private System.Windows.Forms.TabPage companyTab;
		private System.Windows.Forms.SplitContainer companyContainer;
		private ChoiceBox companyChoiceBox;
		private ChoiceBox companyEmployeeBox;
		private ChoiceBox companyProjectBox;
		private CompanyUserControl companyControl;
		private System.Windows.Forms.TabPage contactTab;
		private System.Windows.Forms.SplitContainer contactContainer;
		private ChoiceBox contactChoiceBox;
		private PersonUserControl contactControl;
		private ChoiceBox contactRelationBox;
		private ChoiceBox contactProjectBox;
		private System.Windows.Forms.TabPage projectTab;
		private System.Windows.Forms.SplitContainer projectContainer;
		private ChoiceBox projectChoiceBox;
		private ChoiceBox projectAvailableParticipantsBox;
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
		private System.Windows.Forms.TabPage calendarTab;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.Button createEventBtn;
		private System.Windows.Forms.MonthCalendar monthCalendar;
		private System.Windows.Forms.Label eventListLbl;
		private System.Windows.Forms.ListBox eventListBox;
		private System.Windows.Forms.Label pickDateLbl;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.Label eventCompanyLbl;
		private System.Windows.Forms.Label eventProjectLbl;
		private System.Windows.Forms.TextBox eventCompanyBox;
		private System.Windows.Forms.TextBox eventProjectBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox eventIsMeetingCheckBox;
		private System.Windows.Forms.Button eventAddNoteBtn;
		private System.Windows.Forms.Label eventAddNoteLbl;
		private System.Windows.Forms.TextBox eventAddNoteBox;
		private System.Windows.Forms.ListBox eventNoteBox;
		private System.Windows.Forms.Label eventNotesLbl;
		private System.Windows.Forms.Label stopDateTimeLbl;
		private System.Windows.Forms.Label startDatetimeLbl;
	}
}

