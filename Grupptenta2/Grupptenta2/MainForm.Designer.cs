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
			this.profilePnl = new System.Windows.Forms.Panel();
			this.listProjectsPnl = new System.Windows.Forms.Panel();
			this.goToProjectBtn = new System.Windows.Forms.Button();
			this.projectPnl = new System.Windows.Forms.Panel();
			this.closeProjectPnlBtn = new System.Windows.Forms.Button();
			this.projectLbl = new System.Windows.Forms.Label();
			this.calendarPnl = new System.Windows.Forms.Panel();
			this.calendarLbl = new System.Windows.Forms.Label();
			this.listContactsPnl = new System.Windows.Forms.Panel();
			this.goToContactBtn = new System.Windows.Forms.Button();
			this.contactPnl = new System.Windows.Forms.Panel();
			this.closeContactBtn = new System.Windows.Forms.Button();
			this.contactsViewLbl = new System.Windows.Forms.Label();
			this.listClientsPnl = new System.Windows.Forms.Panel();
			this.goToClientBtn = new System.Windows.Forms.Button();
			this.clientPnl = new System.Windows.Forms.Panel();
			this.closeClientBtn = new System.Windows.Forms.Button();
			this.clientViewLbl = new System.Windows.Forms.Label();
			this.personUserControl1 = new Grupptenta2.PersonUserControl();
			this.menuPanel.SuspendLayout();
			this.profilePnl.SuspendLayout();
			this.listProjectsPnl.SuspendLayout();
			this.projectPnl.SuspendLayout();
			this.calendarPnl.SuspendLayout();
			this.listContactsPnl.SuspendLayout();
			this.contactPnl.SuspendLayout();
			this.listClientsPnl.SuspendLayout();
			this.clientPnl.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.Color.LightSalmon;
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
			this.calendarBtn.Location = new System.Drawing.Point(0, 116);
			this.calendarBtn.Name = "calendarBtn";
			this.calendarBtn.Size = new System.Drawing.Size(200, 23);
			this.calendarBtn.TabIndex = 9;
			this.calendarBtn.Text = "Kalender";
			this.calendarBtn.UseVisualStyleBackColor = true;
			this.calendarBtn.Click += new System.EventHandler(this.calendarBtn_Click);
			// 
			// projectBtn
			// 
			this.projectBtn.Location = new System.Drawing.Point(0, 87);
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
			// profilePnl
			// 
			this.profilePnl.BackColor = System.Drawing.Color.DarkGray;
			this.profilePnl.Controls.Add(this.personUserControl1);
			this.profilePnl.Location = new System.Drawing.Point(0, 654);
			this.profilePnl.Margin = new System.Windows.Forms.Padding(0);
			this.profilePnl.Name = "profilePnl";
			this.profilePnl.Size = new System.Drawing.Size(346, 415);
			this.profilePnl.TabIndex = 1;
			// 
			// listProjectsPnl
			// 
			this.listProjectsPnl.BackColor = System.Drawing.Color.Maroon;
			this.listProjectsPnl.Controls.Add(this.goToProjectBtn);
			this.listProjectsPnl.Location = new System.Drawing.Point(28, 637);
			this.listProjectsPnl.Name = "listProjectsPnl";
			this.listProjectsPnl.Size = new System.Drawing.Size(250, 415);
			this.listProjectsPnl.TabIndex = 2;
			// 
			// goToProjectBtn
			// 
			this.goToProjectBtn.Location = new System.Drawing.Point(39, 33);
			this.goToProjectBtn.Name = "goToProjectBtn";
			this.goToProjectBtn.Size = new System.Drawing.Size(75, 23);
			this.goToProjectBtn.TabIndex = 0;
			this.goToProjectBtn.Text = "Go To Project";
			this.goToProjectBtn.UseVisualStyleBackColor = true;
			this.goToProjectBtn.Click += new System.EventHandler(this.goToProjectBtn_Click);
			// 
			// projectPnl
			// 
			this.projectPnl.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.projectPnl.Controls.Add(this.closeProjectPnlBtn);
			this.projectPnl.Controls.Add(this.projectLbl);
			this.projectPnl.Location = new System.Drawing.Point(103, 623);
			this.projectPnl.Name = "projectPnl";
			this.projectPnl.Size = new System.Drawing.Size(330, 415);
			this.projectPnl.TabIndex = 3;
			// 
			// closeProjectPnlBtn
			// 
			this.closeProjectPnlBtn.Location = new System.Drawing.Point(91, 115);
			this.closeProjectPnlBtn.Name = "closeProjectPnlBtn";
			this.closeProjectPnlBtn.Size = new System.Drawing.Size(75, 23);
			this.closeProjectPnlBtn.TabIndex = 1;
			this.closeProjectPnlBtn.Text = "X";
			this.closeProjectPnlBtn.UseVisualStyleBackColor = true;
			this.closeProjectPnlBtn.Click += new System.EventHandler(this.closeProjectPnlBtn_Click);
			// 
			// projectLbl
			// 
			this.projectLbl.AutoSize = true;
			this.projectLbl.BackColor = System.Drawing.Color.Honeydew;
			this.projectLbl.Location = new System.Drawing.Point(56, 76);
			this.projectLbl.Name = "projectLbl";
			this.projectLbl.Size = new System.Drawing.Size(66, 13);
			this.projectLbl.TabIndex = 0;
			this.projectLbl.Text = "Project View";
			// 
			// calendarPnl
			// 
			this.calendarPnl.BackColor = System.Drawing.Color.PaleTurquoise;
			this.calendarPnl.Controls.Add(this.calendarLbl);
			this.calendarPnl.Location = new System.Drawing.Point(131, 599);
			this.calendarPnl.Name = "calendarPnl";
			this.calendarPnl.Size = new System.Drawing.Size(242, 415);
			this.calendarPnl.TabIndex = 4;
			// 
			// calendarLbl
			// 
			this.calendarLbl.AutoSize = true;
			this.calendarLbl.BackColor = System.Drawing.Color.White;
			this.calendarLbl.Location = new System.Drawing.Point(29, 40);
			this.calendarLbl.Name = "calendarLbl";
			this.calendarLbl.Size = new System.Drawing.Size(75, 13);
			this.calendarLbl.TabIndex = 0;
			this.calendarLbl.Text = "Calendar View";
			// 
			// listContactsPnl
			// 
			this.listContactsPnl.BackColor = System.Drawing.Color.Gainsboro;
			this.listContactsPnl.Controls.Add(this.goToContactBtn);
			this.listContactsPnl.Location = new System.Drawing.Point(194, 582);
			this.listContactsPnl.Name = "listContactsPnl";
			this.listContactsPnl.Size = new System.Drawing.Size(250, 415);
			this.listContactsPnl.TabIndex = 5;
			// 
			// goToContactBtn
			// 
			this.goToContactBtn.Location = new System.Drawing.Point(58, 87);
			this.goToContactBtn.Name = "goToContactBtn";
			this.goToContactBtn.Size = new System.Drawing.Size(111, 23);
			this.goToContactBtn.TabIndex = 0;
			this.goToContactBtn.Text = "Go To Contact";
			this.goToContactBtn.UseVisualStyleBackColor = true;
			this.goToContactBtn.Click += new System.EventHandler(this.goToContactBtn_Click);
			// 
			// contactPnl
			// 
			this.contactPnl.BackColor = System.Drawing.Color.LightSkyBlue;
			this.contactPnl.Controls.Add(this.closeContactBtn);
			this.contactPnl.Controls.Add(this.contactsViewLbl);
			this.contactPnl.Location = new System.Drawing.Point(231, 563);
			this.contactPnl.Name = "contactPnl";
			this.contactPnl.Size = new System.Drawing.Size(224, 415);
			this.contactPnl.TabIndex = 6;
			// 
			// closeContactBtn
			// 
			this.closeContactBtn.Location = new System.Drawing.Point(67, 133);
			this.closeContactBtn.Name = "closeContactBtn";
			this.closeContactBtn.Size = new System.Drawing.Size(75, 23);
			this.closeContactBtn.TabIndex = 1;
			this.closeContactBtn.Text = "X";
			this.closeContactBtn.UseVisualStyleBackColor = true;
			this.closeContactBtn.Click += new System.EventHandler(this.closeContactBtn_Click);
			// 
			// contactsViewLbl
			// 
			this.contactsViewLbl.AutoSize = true;
			this.contactsViewLbl.BackColor = System.Drawing.Color.AliceBlue;
			this.contactsViewLbl.Location = new System.Drawing.Point(78, 96);
			this.contactsViewLbl.Name = "contactsViewLbl";
			this.contactsViewLbl.Size = new System.Drawing.Size(70, 13);
			this.contactsViewLbl.TabIndex = 0;
			this.contactsViewLbl.Text = "Contact View";
			// 
			// listClientsPnl
			// 
			this.listClientsPnl.BackColor = System.Drawing.Color.BlueViolet;
			this.listClientsPnl.Controls.Add(this.goToClientBtn);
			this.listClientsPnl.Location = new System.Drawing.Point(252, 548);
			this.listClientsPnl.Name = "listClientsPnl";
			this.listClientsPnl.Size = new System.Drawing.Size(250, 415);
			this.listClientsPnl.TabIndex = 7;
			// 
			// goToClientBtn
			// 
			this.goToClientBtn.Location = new System.Drawing.Point(49, 58);
			this.goToClientBtn.Name = "goToClientBtn";
			this.goToClientBtn.Size = new System.Drawing.Size(75, 23);
			this.goToClientBtn.TabIndex = 0;
			this.goToClientBtn.Text = "Go To Client";
			this.goToClientBtn.UseVisualStyleBackColor = true;
			this.goToClientBtn.Click += new System.EventHandler(this.goToClientBtn_Click);
			// 
			// clientPnl
			// 
			this.clientPnl.BackColor = System.Drawing.Color.Orchid;
			this.clientPnl.Controls.Add(this.clientViewLbl);
			this.clientPnl.Controls.Add(this.closeClientBtn);
			this.clientPnl.Location = new System.Drawing.Point(275, 530);
			this.clientPnl.Name = "clientPnl";
			this.clientPnl.Size = new System.Drawing.Size(200, 415);
			this.clientPnl.TabIndex = 8;
			// 
			// closeClientBtn
			// 
			this.closeClientBtn.Location = new System.Drawing.Point(64, 57);
			this.closeClientBtn.Name = "closeClientBtn";
			this.closeClientBtn.Size = new System.Drawing.Size(75, 23);
			this.closeClientBtn.TabIndex = 0;
			this.closeClientBtn.Text = "X";
			this.closeClientBtn.UseVisualStyleBackColor = true;
			this.closeClientBtn.Click += new System.EventHandler(this.closeClientBtn_Click);
			// 
			// clientViewLbl
			// 
			this.clientViewLbl.AutoSize = true;
			this.clientViewLbl.Location = new System.Drawing.Point(64, 104);
			this.clientViewLbl.Name = "clientViewLbl";
			this.clientViewLbl.Size = new System.Drawing.Size(59, 13);
			this.clientViewLbl.TabIndex = 1;
			this.clientViewLbl.Text = "Client View";
			// 
			// personUserControl1
			// 
			this.personUserControl1.BackColor = System.Drawing.Color.White;
			this.personUserControl1.Location = new System.Drawing.Point(14, 58);
			this.personUserControl1.Name = "personUserControl1";
			this.personUserControl1.Size = new System.Drawing.Size(242, 312);
			this.personUserControl1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 679);
			this.Controls.Add(this.clientPnl);
			this.Controls.Add(this.listClientsPnl);
			this.Controls.Add(this.contactPnl);
			this.Controls.Add(this.listContactsPnl);
			this.Controls.Add(this.calendarPnl);
			this.Controls.Add(this.listProjectsPnl);
			this.Controls.Add(this.profilePnl);
			this.Controls.Add(this.projectPnl);
			this.Controls.Add(this.menuPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "Form1";
			this.menuPanel.ResumeLayout(false);
			this.profilePnl.ResumeLayout(false);
			this.listProjectsPnl.ResumeLayout(false);
			this.projectPnl.ResumeLayout(false);
			this.projectPnl.PerformLayout();
			this.calendarPnl.ResumeLayout(false);
			this.calendarPnl.PerformLayout();
			this.listContactsPnl.ResumeLayout(false);
			this.contactPnl.ResumeLayout(false);
			this.contactPnl.PerformLayout();
			this.listClientsPnl.ResumeLayout(false);
			this.clientPnl.ResumeLayout(false);
			this.clientPnl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel menuPanel;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel profilePnl;
		private System.Windows.Forms.Button quitBtn;
		private System.Windows.Forms.Button logOutBtn;
		private System.Windows.Forms.Button clientBtn;
		private System.Windows.Forms.Button contactsBtn;
		private System.Windows.Forms.Button calendarBtn;
		private System.Windows.Forms.Button projectBtn;
		private System.Windows.Forms.Button profileBtn;
		private PersonUserControl personUserControl1;
		private System.Windows.Forms.Panel listProjectsPnl;
		private System.Windows.Forms.Button goToProjectBtn;
		private System.Windows.Forms.Panel projectPnl;
		private System.Windows.Forms.Label projectLbl;
		private System.Windows.Forms.Button closeProjectPnlBtn;
		private System.Windows.Forms.Panel calendarPnl;
		private System.Windows.Forms.Label calendarLbl;
		private System.Windows.Forms.Panel listContactsPnl;
		private System.Windows.Forms.Button goToContactBtn;
		private System.Windows.Forms.Panel contactPnl;
		private System.Windows.Forms.Button closeContactBtn;
		private System.Windows.Forms.Label contactsViewLbl;
		private System.Windows.Forms.Panel listClientsPnl;
		private System.Windows.Forms.Button goToClientBtn;
		private System.Windows.Forms.Panel clientPnl;
		private System.Windows.Forms.Label clientViewLbl;
		private System.Windows.Forms.Button closeClientBtn;

	}
}

