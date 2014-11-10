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
			this.choicePnl = new System.Windows.Forms.Panel();
			this.choiceGrid = new System.Windows.Forms.DataGridView();
			this.orderBtn = new System.Windows.Forms.Button();
			this.searchBtn = new System.Windows.Forms.Button();
			this.filterBox = new System.Windows.Forms.ComboBox();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.createBtn = new System.Windows.Forms.Button();
			this.goToChoiceBtn = new System.Windows.Forms.Button();
			this.personPnl = new System.Windows.Forms.Panel();
			this.clientPnl = new System.Windows.Forms.Panel();
			this.projectPnl = new System.Windows.Forms.Panel();
			this.menuPanel.SuspendLayout();
			this.choicePnl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.choiceGrid)).BeginInit();
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
			// choicePnl
			// 
			this.choicePnl.Controls.Add(this.choiceGrid);
			this.choicePnl.Controls.Add(this.orderBtn);
			this.choicePnl.Controls.Add(this.searchBtn);
			this.choicePnl.Controls.Add(this.filterBox);
			this.choicePnl.Controls.Add(this.searchBox);
			this.choicePnl.Controls.Add(this.createBtn);
			this.choicePnl.Controls.Add(this.goToChoiceBtn);
			this.choicePnl.Location = new System.Drawing.Point(203, 0);
			this.choicePnl.Name = "choicePnl";
			this.choicePnl.Size = new System.Drawing.Size(320, 415);
			this.choicePnl.TabIndex = 9;
			// 
			// choiceGrid
			// 
			this.choiceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.choiceGrid.Location = new System.Drawing.Point(15, 73);
			this.choiceGrid.Name = "choiceGrid";
			this.choiceGrid.Size = new System.Drawing.Size(278, 150);
			this.choiceGrid.TabIndex = 15;
			// 
			// orderBtn
			// 
			this.orderBtn.Location = new System.Drawing.Point(217, 44);
			this.orderBtn.Name = "orderBtn";
			this.orderBtn.Size = new System.Drawing.Size(76, 23);
			this.orderBtn.TabIndex = 14;
			this.orderBtn.Text = "Ordna";
			this.orderBtn.UseVisualStyleBackColor = true;
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(217, 15);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(76, 23);
			this.searchBtn.TabIndex = 13;
			this.searchBtn.Text = "Sök";
			this.searchBtn.UseVisualStyleBackColor = true;
			// 
			// filterBox
			// 
			this.filterBox.FormattingEnabled = true;
			this.filterBox.Location = new System.Drawing.Point(15, 46);
			this.filterBox.Name = "filterBox";
			this.filterBox.Size = new System.Drawing.Size(185, 21);
			this.filterBox.TabIndex = 12;
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(15, 17);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(185, 20);
			this.searchBox.TabIndex = 11;
			// 
			// createBtn
			// 
			this.createBtn.Location = new System.Drawing.Point(135, 229);
			this.createBtn.Name = "createBtn";
			this.createBtn.Size = new System.Drawing.Size(76, 23);
			this.createBtn.TabIndex = 10;
			this.createBtn.Text = "Skapa";
			this.createBtn.UseVisualStyleBackColor = true;
			// 
			// goToChoiceBtn
			// 
			this.goToChoiceBtn.Location = new System.Drawing.Point(217, 229);
			this.goToChoiceBtn.Name = "goToChoiceBtn";
			this.goToChoiceBtn.Size = new System.Drawing.Size(76, 23);
			this.goToChoiceBtn.TabIndex = 9;
			this.goToChoiceBtn.Text = "Välj";
			this.goToChoiceBtn.UseVisualStyleBackColor = true;
			this.goToChoiceBtn.Click += new System.EventHandler(this.goToChoiceBtn_Click);
			// 
			// personPnl
			// 
			this.personPnl.BackColor = System.Drawing.Color.Silver;
			this.personPnl.Location = new System.Drawing.Point(529, 0);
			this.personPnl.Name = "personPnl";
			this.personPnl.Size = new System.Drawing.Size(200, 415);
			this.personPnl.TabIndex = 10;
			// 
			// clientPnl
			// 
			this.clientPnl.BackColor = System.Drawing.Color.Maroon;
			this.clientPnl.Location = new System.Drawing.Point(203, 418);
			this.clientPnl.Name = "clientPnl";
			this.clientPnl.Size = new System.Drawing.Size(200, 415);
			this.clientPnl.TabIndex = 11;
			// 
			// projectPnl
			// 
			this.projectPnl.BackColor = System.Drawing.Color.Azure;
			this.projectPnl.Location = new System.Drawing.Point(409, 421);
			this.projectPnl.Name = "projectPnl";
			this.projectPnl.Size = new System.Drawing.Size(200, 415);
			this.projectPnl.TabIndex = 12;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(892, 839);
			this.Controls.Add(this.projectPnl);
			this.Controls.Add(this.clientPnl);
			this.Controls.Add(this.personPnl);
			this.Controls.Add(this.choicePnl);
			this.Controls.Add(this.menuPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "Form1";
			this.menuPanel.ResumeLayout(false);
			this.choicePnl.ResumeLayout(false);
			this.choicePnl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.choiceGrid)).EndInit();
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
		private System.Windows.Forms.Panel choicePnl;
		private System.Windows.Forms.Button goToChoiceBtn;
		private System.Windows.Forms.Button createBtn;
		private System.Windows.Forms.Panel personPnl;
		private System.Windows.Forms.Panel clientPnl;
		private System.Windows.Forms.Panel projectPnl;
		private System.Windows.Forms.Button orderBtn;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.ComboBox filterBox;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.DataGridView choiceGrid;

	}
}

