﻿namespace Grupptenta2
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
			this.SuspendLayout();
			// 
			// searchField
			// 
			this.searchField.Location = new System.Drawing.Point(0, 4);
			this.searchField.Name = "searchField";
			this.searchField.Size = new System.Drawing.Size(195, 20);
			this.searchField.TabIndex = 0;
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(202, 2);
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
			this.orderByBox.Location = new System.Drawing.Point(0, 31);
			this.orderByBox.Name = "orderByBox";
			this.orderByBox.Size = new System.Drawing.Size(195, 21);
			this.orderByBox.TabIndex = 2;
			// 
			// orderByBtn
			// 
			this.orderByBtn.Location = new System.Drawing.Point(202, 29);
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
			this.choiceBox.Location = new System.Drawing.Point(0, 59);
			this.choiceBox.Name = "choiceBox";
			this.choiceBox.Size = new System.Drawing.Size(195, 212);
			this.choiceBox.TabIndex = 4;
			// 
			// goToChoiceBtn
			// 
			this.goToChoiceBtn.Location = new System.Drawing.Point(202, 59);
			this.goToChoiceBtn.Name = "goToChoiceBtn";
			this.goToChoiceBtn.Size = new System.Drawing.Size(76, 23);
			this.goToChoiceBtn.TabIndex = 5;
			this.goToChoiceBtn.Text = "Gå till";
			this.goToChoiceBtn.UseVisualStyleBackColor = true;
			this.goToChoiceBtn.Click += new System.EventHandler(this.goToChoiceBtn_Click);
			// 
			// createBtn
			// 
			this.createBtn.Location = new System.Drawing.Point(202, 88);
			this.createBtn.Name = "createBtn";
			this.createBtn.Size = new System.Drawing.Size(76, 23);
			this.createBtn.TabIndex = 6;
			this.createBtn.Text = "Skapa";
			this.createBtn.UseVisualStyleBackColor = true;
			// 
			// SearchBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.createBtn);
			this.Controls.Add(this.goToChoiceBtn);
			this.Controls.Add(this.choiceBox);
			this.Controls.Add(this.orderByBtn);
			this.Controls.Add(this.orderByBox);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.searchField);
			this.Name = "SearchBox";
			this.Size = new System.Drawing.Size(278, 276);
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
	}
}