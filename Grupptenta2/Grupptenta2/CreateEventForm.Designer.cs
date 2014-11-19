namespace Grupptenta2
{
	partial class CreateEventForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.noteList = new System.Windows.Forms.ListBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.noteListLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addNoteBtn = new System.Windows.Forms.Button();
            this.isMeetingCheckBox = new System.Windows.Forms.CheckBox();
            this.noteLbl = new System.Windows.Forms.Label();
            this.streetTxtBx = new System.Windows.Forms.TextBox();
            this.zipTxtBx = new System.Windows.Forms.TextBox();
            this.cityTxtBx = new System.Windows.Forms.TextBox();
            this.streetLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.personList = new System.Windows.Forms.ListBox();
            this.participantList = new System.Windows.Forms.ListBox();
            this.personListLbl = new System.Windows.Forms.Label();
            this.eventCreationContainer = new System.Windows.Forms.SplitContainer();
            this.stopPicker = new System.Windows.Forms.DateTimePicker();
            this.stopLbl = new System.Windows.Forms.Label();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.startLbl = new System.Windows.Forms.Label();
            this.removeNoteBtn = new System.Windows.Forms.Button();
            this.getAddressBtn = new System.Windows.Forms.Button();
            this.removeParticipantBtn = new System.Windows.Forms.Button();
            this.addParticipantBtn = new System.Windows.Forms.Button();
            this.participantListLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventCreationContainer)).BeginInit();
            this.eventCreationContainer.Panel1.SuspendLayout();
            this.eventCreationContainer.Panel2.SuspendLayout();
            this.eventCreationContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.White;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(16, 30);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 26);
            this.nameBox.TabIndex = 0;
            // 
            // noteList
            // 
            this.noteList.FormattingEnabled = true;
            this.noteList.Location = new System.Drawing.Point(16, 426);
            this.noteList.Name = "noteList";
            this.noteList.Size = new System.Drawing.Size(202, 160);
            this.noteList.TabIndex = 1;
            this.noteList.SelectedIndexChanged += new System.EventHandler(this.noteList_SelectedIndexChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(10, 7);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 20);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Titel";
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(16, 214);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(202, 160);
            this.noteBox.TabIndex = 3;
            // 
            // noteListLbl
            // 
            this.noteListLbl.AutoSize = true;
            this.noteListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteListLbl.Location = new System.Drawing.Point(13, 405);
            this.noteListLbl.Name = "noteListLbl";
            this.noteListLbl.Size = new System.Drawing.Size(93, 18);
            this.noteListLbl.TabIndex = 32;
            this.noteListLbl.Text = "Anteckningar";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(379, 643);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(108, 23);
            this.saveBtn.TabIndex = 33;
            this.saveBtn.Text = "Spara händelse";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addNoteBtn
            // 
            this.addNoteBtn.Location = new System.Drawing.Point(109, 380);
            this.addNoteBtn.Name = "addNoteBtn";
            this.addNoteBtn.Size = new System.Drawing.Size(109, 23);
            this.addNoteBtn.TabIndex = 34;
            this.addNoteBtn.Text = "Spara anteckning";
            this.addNoteBtn.UseVisualStyleBackColor = true;
            this.addNoteBtn.Click += new System.EventHandler(this.addNoteBtn_Click);
            // 
            // isMeetingCheckBox
            // 
            this.isMeetingCheckBox.AutoSize = true;
            this.isMeetingCheckBox.Location = new System.Drawing.Point(168, 58);
            this.isMeetingCheckBox.Name = "isMeetingCheckBox";
            this.isMeetingCheckBox.Size = new System.Drawing.Size(50, 17);
            this.isMeetingCheckBox.TabIndex = 36;
            this.isMeetingCheckBox.Text = "Möte";
            this.isMeetingCheckBox.UseVisualStyleBackColor = true;
            this.isMeetingCheckBox.CheckedChanged += new System.EventHandler(this.isMeetingCheckBox_CheckedChanged);
            // 
            // noteLbl
            // 
            this.noteLbl.AutoSize = true;
            this.noteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLbl.Location = new System.Drawing.Point(13, 193);
            this.noteLbl.Name = "noteLbl";
            this.noteLbl.Size = new System.Drawing.Size(80, 18);
            this.noteLbl.TabIndex = 37;
            this.noteLbl.Text = "Anteckning";
            // 
            // streetTxtBx
            // 
            this.streetTxtBx.Location = new System.Drawing.Point(81, 30);
            this.streetTxtBx.Name = "streetTxtBx";
            this.streetTxtBx.Size = new System.Drawing.Size(156, 20);
            this.streetTxtBx.TabIndex = 38;
            // 
            // zipTxtBx
            // 
            this.zipTxtBx.Location = new System.Drawing.Point(81, 56);
            this.zipTxtBx.Name = "zipTxtBx";
            this.zipTxtBx.Size = new System.Drawing.Size(156, 20);
            this.zipTxtBx.TabIndex = 39;
            // 
            // cityTxtBx
            // 
            this.cityTxtBx.Location = new System.Drawing.Point(81, 82);
            this.cityTxtBx.Name = "cityTxtBx";
            this.cityTxtBx.Size = new System.Drawing.Size(156, 20);
            this.cityTxtBx.TabIndex = 40;
            // 
            // streetLbl
            // 
            this.streetLbl.AutoSize = true;
            this.streetLbl.Location = new System.Drawing.Point(14, 33);
            this.streetLbl.Name = "streetLbl";
            this.streetLbl.Size = new System.Drawing.Size(61, 13);
            this.streetLbl.TabIndex = 41;
            this.streetLbl.Text = "Gatuadress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Postnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Postort";
            // 
            // personList
            // 
            this.personList.FormattingEnabled = true;
            this.personList.Location = new System.Drawing.Point(17, 160);
            this.personList.Name = "personList";
            this.personList.Size = new System.Drawing.Size(220, 160);
            this.personList.TabIndex = 44;
            // 
            // participantList
            // 
            this.participantList.FormattingEnabled = true;
            this.participantList.Location = new System.Drawing.Point(17, 377);
            this.participantList.Name = "participantList";
            this.participantList.Size = new System.Drawing.Size(220, 160);
            this.participantList.TabIndex = 45;
            // 
            // personListLbl
            // 
            this.personListLbl.AutoSize = true;
            this.personListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personListLbl.Location = new System.Drawing.Point(14, 139);
            this.personListLbl.Name = "personListLbl";
            this.personListLbl.Size = new System.Drawing.Size(115, 18);
            this.personListLbl.TabIndex = 46;
            this.personListLbl.Text = "Projektdeltagare";
            // 
            // eventCreationContainer
            // 
            this.eventCreationContainer.Location = new System.Drawing.Point(2, 2);
            this.eventCreationContainer.Name = "eventCreationContainer";
            // 
            // eventCreationContainer.Panel1
            // 
            this.eventCreationContainer.Panel1.Controls.Add(this.stopPicker);
            this.eventCreationContainer.Panel1.Controls.Add(this.stopLbl);
            this.eventCreationContainer.Panel1.Controls.Add(this.startPicker);
            this.eventCreationContainer.Panel1.Controls.Add(this.startLbl);
            this.eventCreationContainer.Panel1.Controls.Add(this.removeNoteBtn);
            this.eventCreationContainer.Panel1.Controls.Add(this.nameLbl);
            this.eventCreationContainer.Panel1.Controls.Add(this.nameBox);
            this.eventCreationContainer.Panel1.Controls.Add(this.noteLbl);
            this.eventCreationContainer.Panel1.Controls.Add(this.noteBox);
            this.eventCreationContainer.Panel1.Controls.Add(this.addNoteBtn);
            this.eventCreationContainer.Panel1.Controls.Add(this.noteListLbl);
            this.eventCreationContainer.Panel1.Controls.Add(this.noteList);
            this.eventCreationContainer.Panel1.Controls.Add(this.isMeetingCheckBox);
            // 
            // eventCreationContainer.Panel2
            // 
            this.eventCreationContainer.Panel2.Controls.Add(this.getAddressBtn);
            this.eventCreationContainer.Panel2.Controls.Add(this.removeParticipantBtn);
            this.eventCreationContainer.Panel2.Controls.Add(this.addParticipantBtn);
            this.eventCreationContainer.Panel2.Controls.Add(this.participantListLbl);
            this.eventCreationContainer.Panel2.Controls.Add(this.addressLbl);
            this.eventCreationContainer.Panel2.Controls.Add(this.participantList);
            this.eventCreationContainer.Panel2.Controls.Add(this.personListLbl);
            this.eventCreationContainer.Panel2.Controls.Add(this.personList);
            this.eventCreationContainer.Panel2.Controls.Add(this.streetLbl);
            this.eventCreationContainer.Panel2.Controls.Add(this.streetTxtBx);
            this.eventCreationContainer.Panel2.Controls.Add(this.zipTxtBx);
            this.eventCreationContainer.Panel2.Controls.Add(this.label2);
            this.eventCreationContainer.Panel2.Controls.Add(this.label1);
            this.eventCreationContainer.Panel2.Controls.Add(this.cityTxtBx);
            this.eventCreationContainer.Size = new System.Drawing.Size(485, 635);
            this.eventCreationContainer.SplitterDistance = 230;
            this.eventCreationContainer.TabIndex = 47;
            // 
            // stopPicker
            // 
            this.stopPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.stopPicker.Location = new System.Drawing.Point(16, 160);
            this.stopPicker.Name = "stopPicker";
            this.stopPicker.Size = new System.Drawing.Size(200, 20);
            this.stopPicker.TabIndex = 53;
            // 
            // stopLbl
            // 
            this.stopLbl.AutoSize = true;
            this.stopLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopLbl.Location = new System.Drawing.Point(13, 139);
            this.stopLbl.Name = "stopLbl";
            this.stopLbl.Size = new System.Drawing.Size(33, 18);
            this.stopLbl.TabIndex = 52;
            this.stopLbl.Text = "Slut";
            // 
            // startPicker
            // 
            this.startPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startPicker.Location = new System.Drawing.Point(16, 106);
            this.startPicker.Name = "startPicker";
            this.startPicker.Size = new System.Drawing.Size(200, 20);
            this.startPicker.TabIndex = 50;
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLbl.Location = new System.Drawing.Point(13, 85);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(39, 18);
            this.startLbl.TabIndex = 51;
            this.startLbl.Text = "Start";
            // 
            // removeNoteBtn
            // 
            this.removeNoteBtn.Location = new System.Drawing.Point(110, 592);
            this.removeNoteBtn.Name = "removeNoteBtn";
            this.removeNoteBtn.Size = new System.Drawing.Size(108, 23);
            this.removeNoteBtn.TabIndex = 50;
            this.removeNoteBtn.Text = "Ta bort anteckning";
            this.removeNoteBtn.UseVisualStyleBackColor = true;
            this.removeNoteBtn.Click += new System.EventHandler(this.removeNoteBtn_Click);
            // 
            // getAddressBtn
            // 
            this.getAddressBtn.Location = new System.Drawing.Point(157, 108);
            this.getAddressBtn.Name = "getAddressBtn";
            this.getAddressBtn.Size = new System.Drawing.Size(80, 23);
            this.getAddressBtn.TabIndex = 50;
            this.getAddressBtn.Text = "Hämta adress";
            this.getAddressBtn.UseVisualStyleBackColor = true;
            this.getAddressBtn.Click += new System.EventHandler(this.getAddressBtn_Click);
            // 
            // removeParticipantBtn
            // 
            this.removeParticipantBtn.Location = new System.Drawing.Point(129, 543);
            this.removeParticipantBtn.Name = "removeParticipantBtn";
            this.removeParticipantBtn.Size = new System.Drawing.Size(108, 23);
            this.removeParticipantBtn.TabIndex = 48;
            this.removeParticipantBtn.Text = "Ta bort deltagare";
            this.removeParticipantBtn.UseVisualStyleBackColor = true;
            this.removeParticipantBtn.Click += new System.EventHandler(this.removeParticipantBtn_Click);
            // 
            // addParticipantBtn
            // 
            this.addParticipantBtn.Location = new System.Drawing.Point(129, 326);
            this.addParticipantBtn.Name = "addParticipantBtn";
            this.addParticipantBtn.Size = new System.Drawing.Size(108, 23);
            this.addParticipantBtn.TabIndex = 49;
            this.addParticipantBtn.Text = "Lägg till deltagare";
            this.addParticipantBtn.UseVisualStyleBackColor = true;
            this.addParticipantBtn.Click += new System.EventHandler(this.addParticipantBtn_Click);
            // 
            // participantListLbl
            // 
            this.participantListLbl.AutoSize = true;
            this.participantListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantListLbl.Location = new System.Drawing.Point(14, 356);
            this.participantListLbl.Name = "participantListLbl";
            this.participantListLbl.Size = new System.Drawing.Size(110, 18);
            this.participantListLbl.TabIndex = 49;
            this.participantListLbl.Text = "Mötesdeltagare";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(3, 7);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(81, 18);
            this.addressLbl.TabIndex = 48;
            this.addressLbl.Text = "Mötesplats";
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 669);
            this.Controls.Add(this.eventCreationContainer);
            this.Controls.Add(this.saveBtn);
            this.Name = "CreateEventForm";
            this.Text = "CreateEvent";
            this.eventCreationContainer.Panel1.ResumeLayout(false);
            this.eventCreationContainer.Panel1.PerformLayout();
            this.eventCreationContainer.Panel2.ResumeLayout(false);
            this.eventCreationContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventCreationContainer)).EndInit();
            this.eventCreationContainer.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.ListBox noteList;
		private System.Windows.Forms.Label nameLbl;
		private System.Windows.Forms.TextBox noteBox;
		private System.Windows.Forms.Label noteListLbl;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Button addNoteBtn;
		private System.Windows.Forms.CheckBox isMeetingCheckBox;
		private System.Windows.Forms.Label noteLbl;
		private System.Windows.Forms.TextBox streetTxtBx;
		private System.Windows.Forms.TextBox zipTxtBx;
		private System.Windows.Forms.TextBox cityTxtBx;
		private System.Windows.Forms.Label streetLbl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox personList;
		private System.Windows.Forms.ListBox participantList;
		private System.Windows.Forms.Label personListLbl;
		private System.Windows.Forms.SplitContainer eventCreationContainer;
		private System.Windows.Forms.Label startLbl;
		private System.Windows.Forms.Button removeNoteBtn;
		private System.Windows.Forms.Button removeParticipantBtn;
		private System.Windows.Forms.Button addParticipantBtn;
		private System.Windows.Forms.Label participantListLbl;
		private System.Windows.Forms.Label addressLbl;
		private System.Windows.Forms.DateTimePicker startPicker;
		private System.Windows.Forms.Label stopLbl;
		private System.Windows.Forms.DateTimePicker stopPicker;
        private System.Windows.Forms.Button getAddressBtn;
	}
}