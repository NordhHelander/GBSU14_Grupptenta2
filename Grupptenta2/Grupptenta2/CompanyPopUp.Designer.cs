﻿namespace Grupptenta2
{
	partial class CompanyPopUp
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
			this.companyUserForm = new Grupptenta2.CompanyUserControl();
			this.SuspendLayout();
			// 
			// companyUserForm
			// 
			this.companyUserForm.BackColor = System.Drawing.Color.White;
			this.companyUserForm.Location = new System.Drawing.Point(13, 13);
			this.companyUserForm.Name = "companyUserForm";
			this.companyUserForm.Size = new System.Drawing.Size(810, 320);
			this.companyUserForm.TabIndex = 0;
			// 
			// CompanyPopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(834, 344);
			this.Controls.Add(this.companyUserForm);
			this.Name = "CompanyPopUp";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Text = "CompanyPopUp";
			this.ResumeLayout(false);

		}

		#endregion

		private CompanyUserControl companyUserForm;
	}
}