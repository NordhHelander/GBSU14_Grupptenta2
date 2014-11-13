namespace Grupptenta2
{
	partial class CompanyUserForm
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
			this.activeLbl = new System.Windows.Forms.Label();
			this.editSaveBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.employeesLbl = new System.Windows.Forms.Label();
			this.searchBox1 = new Grupptenta2.SearchBox();
			this.searchBox2 = new Grupptenta2.SearchBox();
			this.projectSearchField = new System.Windows.Forms.TextBox();
			this.projectOrderBox = new System.Windows.Forms.ComboBox();
			this.projectBox = new System.Windows.Forms.ListBox();
			this.projectSearchBtn = new System.Windows.Forms.Button();
			this.projectOrderBtn = new System.Windows.Forms.Button();
			this.goToProjectBtn = new System.Windows.Forms.Button();
			this.createProjectBtn = new System.Windows.Forms.Button();
			this.contactSearchField = new System.Windows.Forms.TextBox();
			this.contactOrderBox = new System.Windows.Forms.ComboBox();
			this.contactBox = new System.Windows.Forms.ListBox();
			this.companySearchBox = new System.Windows.Forms.Button();
			this.contactOrderBtn = new System.Windows.Forms.Button();
			this.goToContactBtn = new System.Windows.Forms.Button();
			this.createContactBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nameBox
			// 
			this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameBox.Location = new System.Drawing.Point(3, 3);
			this.nameBox.Name = "nameBox";
			this.nameBox.ReadOnly = true;
			this.nameBox.Size = new System.Drawing.Size(178, 26);
			this.nameBox.TabIndex = 0;
			// 
			// idBox
			// 
			this.idBox.Location = new System.Drawing.Point(81, 35);
			this.idBox.Name = "idBox";
			this.idBox.ReadOnly = true;
			this.idBox.Size = new System.Drawing.Size(100, 20);
			this.idBox.TabIndex = 1;
			// 
			// streetBox
			// 
			this.streetBox.Location = new System.Drawing.Point(81, 61);
			this.streetBox.Name = "streetBox";
			this.streetBox.ReadOnly = true;
			this.streetBox.Size = new System.Drawing.Size(100, 20);
			this.streetBox.TabIndex = 2;
			// 
			// zipBox
			// 
			this.zipBox.Location = new System.Drawing.Point(81, 87);
			this.zipBox.Name = "zipBox";
			this.zipBox.ReadOnly = true;
			this.zipBox.Size = new System.Drawing.Size(100, 20);
			this.zipBox.TabIndex = 3;
			// 
			// cityBox
			// 
			this.cityBox.Location = new System.Drawing.Point(81, 113);
			this.cityBox.Name = "cityBox";
			this.cityBox.ReadOnly = true;
			this.cityBox.Size = new System.Drawing.Size(100, 20);
			this.cityBox.TabIndex = 4;
			// 
			// activeCheckBox
			// 
			this.activeCheckBox.AutoSize = true;
			this.activeCheckBox.Enabled = false;
			this.activeCheckBox.Location = new System.Drawing.Point(81, 139);
			this.activeCheckBox.Name = "activeCheckBox";
			this.activeCheckBox.Size = new System.Drawing.Size(15, 14);
			this.activeCheckBox.TabIndex = 5;
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
			// activeLbl
			// 
			this.activeLbl.AutoSize = true;
			this.activeLbl.Location = new System.Drawing.Point(0, 139);
			this.activeLbl.Name = "activeLbl";
			this.activeLbl.Size = new System.Drawing.Size(34, 13);
			this.activeLbl.TabIndex = 10;
			this.activeLbl.Text = "Aktivt";
			// 
			// editSaveBtn
			// 
			this.editSaveBtn.Location = new System.Drawing.Point(106, 159);
			this.editSaveBtn.Name = "editSaveBtn";
			this.editSaveBtn.Size = new System.Drawing.Size(75, 23);
			this.editSaveBtn.TabIndex = 11;
			this.editSaveBtn.Text = "Redigera";
			this.editSaveBtn.UseVisualStyleBackColor = true;
			this.editSaveBtn.Click += new System.EventHandler(this.editSaveBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(211, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 18);
			this.label1.TabIndex = 14;
			this.label1.Text = "Projekt";
			// 
			// employeesLbl
			// 
			this.employeesLbl.AutoSize = true;
			this.employeesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeesLbl.Location = new System.Drawing.Point(521, 10);
			this.employeesLbl.Name = "employeesLbl";
			this.employeesLbl.Size = new System.Drawing.Size(72, 18);
			this.employeesLbl.TabIndex = 15;
			this.employeesLbl.Text = "Kontakter";
			// 
			// searchBox1
			// 
			this.searchBox1.Location = new System.Drawing.Point(0, 0);
			this.searchBox1.Name = "searchBox1";
			this.searchBox1.Size = new System.Drawing.Size(278, 276);
			this.searchBox1.TabIndex = 0;
			// 
			// searchBox2
			// 
			this.searchBox2.Location = new System.Drawing.Point(0, 0);
			this.searchBox2.Name = "searchBox2";
			this.searchBox2.Size = new System.Drawing.Size(278, 276);
			this.searchBox2.TabIndex = 0;
			// 
			// projectSearchField
			// 
			this.projectSearchField.Location = new System.Drawing.Point(214, 35);
			this.projectSearchField.Name = "projectSearchField";
			this.projectSearchField.Size = new System.Drawing.Size(195, 20);
			this.projectSearchField.TabIndex = 16;
			// 
			// projectOrderBox
			// 
			this.projectOrderBox.FormattingEnabled = true;
			this.projectOrderBox.Location = new System.Drawing.Point(214, 61);
			this.projectOrderBox.Name = "projectOrderBox";
			this.projectOrderBox.Size = new System.Drawing.Size(195, 21);
			this.projectOrderBox.TabIndex = 17;
			// 
			// projectBox
			// 
			this.projectBox.FormattingEnabled = true;
			this.projectBox.Location = new System.Drawing.Point(214, 88);
			this.projectBox.Name = "projectBox";
			this.projectBox.Size = new System.Drawing.Size(195, 212);
			this.projectBox.TabIndex = 18;
			// 
			// projectSearchBtn
			// 
			this.projectSearchBtn.Location = new System.Drawing.Point(415, 33);
			this.projectSearchBtn.Name = "projectSearchBtn";
			this.projectSearchBtn.Size = new System.Drawing.Size(76, 23);
			this.projectSearchBtn.TabIndex = 19;
			this.projectSearchBtn.Text = "Sök";
			this.projectSearchBtn.UseVisualStyleBackColor = true;
			// 
			// projectOrderBtn
			// 
			this.projectOrderBtn.Location = new System.Drawing.Point(415, 61);
			this.projectOrderBtn.Name = "projectOrderBtn";
			this.projectOrderBtn.Size = new System.Drawing.Size(76, 23);
			this.projectOrderBtn.TabIndex = 20;
			this.projectOrderBtn.Text = "Ordna";
			this.projectOrderBtn.UseVisualStyleBackColor = true;
			// 
			// goToProjectBtn
			// 
			this.goToProjectBtn.Location = new System.Drawing.Point(415, 90);
			this.goToProjectBtn.Name = "goToProjectBtn";
			this.goToProjectBtn.Size = new System.Drawing.Size(76, 23);
			this.goToProjectBtn.TabIndex = 21;
			this.goToProjectBtn.Text = "Gå till";
			this.goToProjectBtn.UseVisualStyleBackColor = true;
			// 
			// createProjectBtn
			// 
			this.createProjectBtn.Location = new System.Drawing.Point(415, 119);
			this.createProjectBtn.Name = "createProjectBtn";
			this.createProjectBtn.Size = new System.Drawing.Size(76, 23);
			this.createProjectBtn.TabIndex = 22;
			this.createProjectBtn.Text = "Skapa";
			this.createProjectBtn.UseVisualStyleBackColor = true;
			// 
			// contactSearchField
			// 
			this.contactSearchField.Location = new System.Drawing.Point(524, 35);
			this.contactSearchField.Name = "contactSearchField";
			this.contactSearchField.Size = new System.Drawing.Size(195, 20);
			this.contactSearchField.TabIndex = 23;
			// 
			// contactOrderBox
			// 
			this.contactOrderBox.FormattingEnabled = true;
			this.contactOrderBox.Location = new System.Drawing.Point(524, 61);
			this.contactOrderBox.Name = "contactOrderBox";
			this.contactOrderBox.Size = new System.Drawing.Size(195, 21);
			this.contactOrderBox.TabIndex = 24;
			// 
			// contactBox
			// 
			this.contactBox.FormattingEnabled = true;
			this.contactBox.Location = new System.Drawing.Point(524, 88);
			this.contactBox.Name = "contactBox";
			this.contactBox.Size = new System.Drawing.Size(195, 212);
			this.contactBox.TabIndex = 25;
			// 
			// companySearchBox
			// 
			this.companySearchBox.Location = new System.Drawing.Point(725, 35);
			this.companySearchBox.Name = "companySearchBox";
			this.companySearchBox.Size = new System.Drawing.Size(76, 23);
			this.companySearchBox.TabIndex = 26;
			this.companySearchBox.Text = "Sök";
			this.companySearchBox.UseVisualStyleBackColor = true;
			// 
			// contactOrderBtn
			// 
			this.contactOrderBtn.Location = new System.Drawing.Point(725, 61);
			this.contactOrderBtn.Name = "contactOrderBtn";
			this.contactOrderBtn.Size = new System.Drawing.Size(76, 23);
			this.contactOrderBtn.TabIndex = 27;
			this.contactOrderBtn.Text = "Ordna";
			this.contactOrderBtn.UseVisualStyleBackColor = true;
			// 
			// goToContactBtn
			// 
			this.goToContactBtn.Location = new System.Drawing.Point(725, 90);
			this.goToContactBtn.Name = "goToContactBtn";
			this.goToContactBtn.Size = new System.Drawing.Size(76, 23);
			this.goToContactBtn.TabIndex = 28;
			this.goToContactBtn.Text = "Gå till";
			this.goToContactBtn.UseVisualStyleBackColor = true;
			// 
			// createContactBtn
			// 
			this.createContactBtn.Location = new System.Drawing.Point(725, 119);
			this.createContactBtn.Name = "createContactBtn";
			this.createContactBtn.Size = new System.Drawing.Size(76, 23);
			this.createContactBtn.TabIndex = 29;
			this.createContactBtn.Text = "Skapa";
			this.createContactBtn.UseVisualStyleBackColor = true;
			// 
			// CompanyUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.createContactBtn);
			this.Controls.Add(this.goToContactBtn);
			this.Controls.Add(this.contactOrderBtn);
			this.Controls.Add(this.companySearchBox);
			this.Controls.Add(this.contactBox);
			this.Controls.Add(this.contactOrderBox);
			this.Controls.Add(this.contactSearchField);
			this.Controls.Add(this.createProjectBtn);
			this.Controls.Add(this.goToProjectBtn);
			this.Controls.Add(this.projectOrderBtn);
			this.Controls.Add(this.projectSearchBtn);
			this.Controls.Add(this.projectBox);
			this.Controls.Add(this.projectOrderBox);
			this.Controls.Add(this.projectSearchField);
			this.Controls.Add(this.employeesLbl);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.editSaveBtn);
			this.Controls.Add(this.activeLbl);
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
			this.Name = "CompanyUserForm";
			this.Size = new System.Drawing.Size(810, 312);
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
		private System.Windows.Forms.Label activeLbl;
		private System.Windows.Forms.Button editSaveBtn;
		private SearchBox searchBox1;
		private SearchBox searchBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label employeesLbl;
		private System.Windows.Forms.TextBox projectSearchField;
		private System.Windows.Forms.ComboBox projectOrderBox;
		private System.Windows.Forms.ListBox projectBox;
		private System.Windows.Forms.Button projectSearchBtn;
		private System.Windows.Forms.Button projectOrderBtn;
		private System.Windows.Forms.Button goToProjectBtn;
		private System.Windows.Forms.Button createProjectBtn;
		private System.Windows.Forms.TextBox contactSearchField;
		private System.Windows.Forms.ComboBox contactOrderBox;
		private System.Windows.Forms.ListBox contactBox;
		private System.Windows.Forms.Button companySearchBox;
		private System.Windows.Forms.Button contactOrderBtn;
		private System.Windows.Forms.Button goToContactBtn;
		private System.Windows.Forms.Button createContactBtn;
	}
}
