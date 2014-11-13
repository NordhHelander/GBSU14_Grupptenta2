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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.quitBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.clientBtn = new System.Windows.Forms.Button();
            this.contactsBtn = new System.Windows.Forms.Button();
            this.calendarBtn = new System.Windows.Forms.Button();
            this.projectBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clientPnl = new System.Windows.Forms.Panel();
            this.projectPnl = new System.Windows.Forms.Panel();
            this.choosePersonPnl = new System.Windows.Forms.Panel();
            this.personSearchBox = new Grupptenta2.SearchBox();
            this.chooseClientPnl = new System.Windows.Forms.Panel();
            this.clientSearchBox = new Grupptenta2.SearchBox();
            this.chooseProjectPnl = new System.Windows.Forms.Panel();
            this.projectSearchBox = new Grupptenta2.SearchBox();
            this.personPnl = new System.Windows.Forms.Panel();
            this.relationBox = new Grupptenta2.CustomListBox();
            this.projectBox = new Grupptenta2.CustomListBox();
            this.personInfoBox1 = new Grupptenta2.PersonInfoBox();
            this.createPersonPnl = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.choosePersonPnl.SuspendLayout();
            this.chooseClientPnl.SuspendLayout();
            this.chooseProjectPnl.SuspendLayout();
            this.personPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.DimGray;
            this.menuPanel.Controls.Add(this.quitBtn);
            this.menuPanel.Controls.Add(this.logOutBtn);
            this.menuPanel.Controls.Add(this.clientBtn);
            this.menuPanel.Controls.Add(this.contactsBtn);
            this.menuPanel.Controls.Add(this.calendarBtn);
            this.menuPanel.Controls.Add(this.projectBtn);
            this.menuPanel.Controls.Add(this.profileBtn);
            this.menuPanel.Controls.Add(this.button7);
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 415);
            this.menuPanel.TabIndex = 0;
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(0, 232);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(200, 23);
            this.quitBtn.TabIndex = 13;
            this.quitBtn.Text = "Avsluta";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(0, 203);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(200, 23);
            this.logOutBtn.TabIndex = 12;
            this.logOutBtn.Text = "Logga ut";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // clientBtn
            // 
            this.clientBtn.Location = new System.Drawing.Point(0, 174);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(200, 23);
            this.clientBtn.TabIndex = 11;
            this.clientBtn.Text = "Kundföretag";
            this.clientBtn.UseVisualStyleBackColor = true;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // contactsBtn
            // 
            this.contactsBtn.Location = new System.Drawing.Point(0, 145);
            this.contactsBtn.Name = "contactsBtn";
            this.contactsBtn.Size = new System.Drawing.Size(200, 23);
            this.contactsBtn.TabIndex = 10;
            this.contactsBtn.Text = "Kontakter";
            this.contactsBtn.UseVisualStyleBackColor = true;
            this.contactsBtn.Click += new System.EventHandler(this.contactsBtn_Click);
            // 
            // calendarBtn
            // 
            this.calendarBtn.Location = new System.Drawing.Point(0, 87);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(200, 23);
            this.calendarBtn.TabIndex = 9;
            this.calendarBtn.Text = "Kalender";
            this.calendarBtn.UseVisualStyleBackColor = true;
            this.calendarBtn.Click += new System.EventHandler(this.calendarBtn_Click);
            // 
            // projectBtn
            // 
            this.projectBtn.Location = new System.Drawing.Point(0, 116);
            this.projectBtn.Name = "projectBtn";
            this.projectBtn.Size = new System.Drawing.Size(200, 23);
            this.projectBtn.TabIndex = 8;
            this.projectBtn.Text = "Projekt";
            this.projectBtn.UseVisualStyleBackColor = true;
            this.projectBtn.Click += new System.EventHandler(this.projectBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.Location = new System.Drawing.Point(0, 58);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(200, 23);
            this.profileBtn.TabIndex = 7;
            this.profileBtn.Text = "Profil";
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(103, 236);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(0, 0);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(0, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inloggad som: Tant Nordh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clientPnl
            // 
            this.clientPnl.BackColor = System.Drawing.Color.Maroon;
            this.clientPnl.Location = new System.Drawing.Point(374, 787);
            this.clientPnl.Name = "clientPnl";
            this.clientPnl.Size = new System.Drawing.Size(380, 415);
            this.clientPnl.TabIndex = 11;
            // 
            // projectPnl
            // 
            this.projectPnl.BackColor = System.Drawing.Color.Azure;
            this.projectPnl.Location = new System.Drawing.Point(393, 767);
            this.projectPnl.Name = "projectPnl";
            this.projectPnl.Size = new System.Drawing.Size(380, 415);
            this.projectPnl.TabIndex = 12;
            // 
            // choosePersonPnl
            // 
            this.choosePersonPnl.Controls.Add(this.personSearchBox);
            this.choosePersonPnl.Location = new System.Drawing.Point(12, 529);
            this.choosePersonPnl.Name = "choosePersonPnl";
            this.choosePersonPnl.Size = new System.Drawing.Size(320, 415);
            this.choosePersonPnl.TabIndex = 14;
            // 
            // personSearchBox
            // 
            this.personSearchBox.Location = new System.Drawing.Point(18, 12);
            this.personSearchBox.Name = "personSearchBox";
            this.personSearchBox.Size = new System.Drawing.Size(278, 276);
            this.personSearchBox.TabIndex = 0;
            // 
            // chooseClientPnl
            // 
            this.chooseClientPnl.Controls.Add(this.clientSearchBox);
            this.chooseClientPnl.Location = new System.Drawing.Point(94, 481);
            this.chooseClientPnl.Name = "chooseClientPnl";
            this.chooseClientPnl.Size = new System.Drawing.Size(320, 415);
            this.chooseClientPnl.TabIndex = 15;
            // 
            // clientSearchBox
            // 
            this.clientSearchBox.Location = new System.Drawing.Point(18, 12);
            this.clientSearchBox.Name = "clientSearchBox";
            this.clientSearchBox.Size = new System.Drawing.Size(278, 276);
            this.clientSearchBox.TabIndex = 0;
            // 
            // chooseProjectPnl
            // 
            this.chooseProjectPnl.Controls.Add(this.projectSearchBox);
            this.chooseProjectPnl.Location = new System.Drawing.Point(251, 453);
            this.chooseProjectPnl.Name = "chooseProjectPnl";
            this.chooseProjectPnl.Size = new System.Drawing.Size(320, 415);
            this.chooseProjectPnl.TabIndex = 16;
            // 
            // projectSearchBox
            // 
            this.projectSearchBox.Location = new System.Drawing.Point(18, 12);
            this.projectSearchBox.Name = "projectSearchBox";
            this.projectSearchBox.Size = new System.Drawing.Size(278, 276);
            this.projectSearchBox.TabIndex = 0;
            // 
            // personPnl
            // 
            this.personPnl.BackColor = System.Drawing.Color.White;
            this.personPnl.Controls.Add(this.relationBox);
            this.personPnl.Controls.Add(this.projectBox);
            this.personPnl.Controls.Add(this.personInfoBox1);
            this.personPnl.Location = new System.Drawing.Point(494, 436);
            this.personPnl.Margin = new System.Windows.Forms.Padding(0);
            this.personPnl.Name = "personPnl";
            this.personPnl.Size = new System.Drawing.Size(700, 415);
            this.personPnl.TabIndex = 10;
            // 
            // relationBox
            // 
            this.relationBox.BackColor = System.Drawing.Color.White;
            this.relationBox.Location = new System.Drawing.Point(307, 203);
            this.relationBox.Name = "relationBox";
            this.relationBox.Size = new System.Drawing.Size(241, 184);
            this.relationBox.TabIndex = 2;
            // 
            // projectBox
            // 
            this.projectBox.BackColor = System.Drawing.Color.White;
            this.projectBox.Location = new System.Drawing.Point(307, 13);
            this.projectBox.Name = "projectBox";
            this.projectBox.Size = new System.Drawing.Size(241, 184);
            this.projectBox.TabIndex = 1;
            // 
            // personInfoBox1
            // 
            this.personInfoBox1.Location = new System.Drawing.Point(3, 3);
            this.personInfoBox1.Name = "personInfoBox1";
            this.personInfoBox1.Size = new System.Drawing.Size(240, 395);
            this.personInfoBox1.TabIndex = 0;
            // 
            // createPersonPnl
            // 
            this.createPersonPnl.Location = new System.Drawing.Point(203, 0);
            this.createPersonPnl.Margin = new System.Windows.Forms.Padding(0);
            this.createPersonPnl.Name = "createPersonPnl";
            this.createPersonPnl.Size = new System.Drawing.Size(700, 415);
            this.createPersonPnl.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 839);
            this.Controls.Add(this.createPersonPnl);
            this.Controls.Add(this.chooseProjectPnl);
            this.Controls.Add(this.chooseClientPnl);
            this.Controls.Add(this.choosePersonPnl);
            this.Controls.Add(this.projectPnl);
            this.Controls.Add(this.clientPnl);
            this.Controls.Add(this.personPnl);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.choosePersonPnl.ResumeLayout(false);
            this.chooseClientPnl.ResumeLayout(false);
            this.chooseProjectPnl.ResumeLayout(false);
            this.personPnl.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel menuPanel;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button quitBtn;
		private System.Windows.Forms.Button logOutBtn;
		private System.Windows.Forms.Button clientBtn;
		private System.Windows.Forms.Button contactsBtn;
		private System.Windows.Forms.Button calendarBtn;
		private System.Windows.Forms.Button projectBtn;
		private System.Windows.Forms.Button profileBtn;
		private System.Windows.Forms.Panel clientPnl;
		private System.Windows.Forms.Panel projectPnl;
		private System.Windows.Forms.Panel choosePersonPnl;
		private SearchBox personSearchBox;
		private System.Windows.Forms.Panel chooseClientPnl;
		private SearchBox clientSearchBox;
		private System.Windows.Forms.Panel chooseProjectPnl;
		private SearchBox projectSearchBox;
		private System.Windows.Forms.Panel personPnl;
		private PersonInfoBox personInfoBox1;
		private CustomListBox relationBox;
		private CustomListBox projectBox;
		private System.Windows.Forms.Panel createPersonPnl;
	}
}

