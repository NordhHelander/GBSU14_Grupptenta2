namespace Grupptenta2
{
	partial class SearchBox
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
			this.searchField = new System.Windows.Forms.TextBox();
			this.searchBtn = new System.Windows.Forms.Button();
			this.orderByBox = new System.Windows.Forms.ComboBox();
			this.orderByBtn = new System.Windows.Forms.Button();
			this.choiceBox = new System.Windows.Forms.ListBox();
			this.goToChoiceBtn = new System.Windows.Forms.Button();
			this.createBtn = new System.Windows.Forms.Button();
			this.headerLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// searchField
			// 
			this.searchField.Location = new System.Drawing.Point(0, 24);
			this.searchField.Name = "searchField";
			this.searchField.Size = new System.Drawing.Size(195, 20);
			this.searchField.TabIndex = 0;
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(199, 24);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(76, 23);
			this.searchBtn.TabIndex = 1;
			this.searchBtn.Text = "Sök";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// orderByBox
			// 
			this.orderByBox.FormattingEnabled = true;
			this.orderByBox.Location = new System.Drawing.Point(0, 50);
			this.orderByBox.Name = "orderByBox";
			this.orderByBox.Size = new System.Drawing.Size(195, 21);
			this.orderByBox.TabIndex = 2;
			// 
			// orderByBtn
			// 
			this.orderByBtn.Location = new System.Drawing.Point(199, 50);
			this.orderByBtn.Name = "orderByBtn";
			this.orderByBtn.Size = new System.Drawing.Size(76, 23);
			this.orderByBtn.TabIndex = 3;
			this.orderByBtn.Text = "Ordna";
			this.orderByBtn.UseVisualStyleBackColor = true;
			this.orderByBtn.Click += new System.EventHandler(this.orderBy_Click);
			// 
			// choiceBox
			// 
			this.choiceBox.FormattingEnabled = true;
			this.choiceBox.Location = new System.Drawing.Point(0, 77);
			this.choiceBox.Name = "choiceBox";
			this.choiceBox.Size = new System.Drawing.Size(195, 212);
			this.choiceBox.TabIndex = 4;
			this.choiceBox.SelectedIndexChanged += new System.EventHandler(this.choiceBox_SelectedIndexChanged);
			this.choiceBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.choiceBox_DoubleClick);
			// 
			// goToChoiceBtn
			// 
			this.goToChoiceBtn.Location = new System.Drawing.Point(199, 77);
			this.goToChoiceBtn.Name = "goToChoiceBtn";
			this.goToChoiceBtn.Size = new System.Drawing.Size(76, 23);
			this.goToChoiceBtn.TabIndex = 5;
			this.goToChoiceBtn.Text = "Gå till";
			this.goToChoiceBtn.UseVisualStyleBackColor = true;
			this.goToChoiceBtn.Click += new System.EventHandler(this.goToChoiceBtn_Click);
			// 
			// createBtn
			// 
			this.createBtn.Location = new System.Drawing.Point(199, 106);
			this.createBtn.Name = "createBtn";
			this.createBtn.Size = new System.Drawing.Size(76, 23);
			this.createBtn.TabIndex = 6;
			this.createBtn.Text = "Skapa";
			this.createBtn.UseVisualStyleBackColor = true;
			this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
			// 
			// headerLbl
			// 
			this.headerLbl.AutoSize = true;
			this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLbl.Location = new System.Drawing.Point(3, 3);
			this.headerLbl.Name = "headerLbl";
			this.headerLbl.Size = new System.Drawing.Size(0, 18);
			this.headerLbl.TabIndex = 32;
			// 
			// SearchBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.headerLbl);
			this.Controls.Add(this.createBtn);
			this.Controls.Add(this.goToChoiceBtn);
			this.Controls.Add(this.choiceBox);
			this.Controls.Add(this.orderByBtn);
			this.Controls.Add(this.orderByBox);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.searchField);
			this.Name = "SearchBox";
			this.Size = new System.Drawing.Size(278, 307);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox searchField;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.ComboBox orderByBox;
		private System.Windows.Forms.Button orderByBtn;
		private System.Windows.Forms.ListBox choiceBox;
		private System.Windows.Forms.Button goToChoiceBtn;
		private System.Windows.Forms.Button createBtn;
		private System.Windows.Forms.Label headerLbl;
	}
}
