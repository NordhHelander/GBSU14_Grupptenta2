using CodeBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestClasses;

namespace Grupptenta2
{
	partial class CreateCompanyForm : Form
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
            this.streetBox = new System.Windows.Forms.TextBox();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.streetLbl = new System.Windows.Forms.Label();
            this.zipLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.activeLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(12, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(178, 26);
            this.nameBox.TabIndex = 1;
            this.nameBox.Text = "Företagets namn";
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(90, 44);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(100, 20);
            this.streetBox.TabIndex = 3;
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(90, 70);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(100, 20);
            this.zipBox.TabIndex = 4;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(90, 96);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 5;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Checked = true;
            this.activeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeCheckBox.Location = new System.Drawing.Point(90, 122);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.activeCheckBox.TabIndex = 6;
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // streetLbl
            // 
            this.streetLbl.AutoSize = true;
            this.streetLbl.Location = new System.Drawing.Point(9, 47);
            this.streetLbl.Name = "streetLbl";
            this.streetLbl.Size = new System.Drawing.Size(61, 13);
            this.streetLbl.TabIndex = 8;
            this.streetLbl.Text = "Gatuadress";
            // 
            // zipLbl
            // 
            this.zipLbl.AutoSize = true;
            this.zipLbl.Location = new System.Drawing.Point(9, 73);
            this.zipLbl.Name = "zipLbl";
            this.zipLbl.Size = new System.Drawing.Size(65, 13);
            this.zipLbl.TabIndex = 9;
            this.zipLbl.Text = "Postnummer";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(9, 99);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(40, 13);
            this.cityLbl.TabIndex = 10;
            this.cityLbl.Text = "Postort";
            // 
            // activeLbl
            // 
            this.activeLbl.AutoSize = true;
            this.activeLbl.Location = new System.Drawing.Point(9, 122);
            this.activeLbl.Name = "activeLbl";
            this.activeLbl.Size = new System.Drawing.Size(34, 13);
            this.activeLbl.TabIndex = 11;
            this.activeLbl.Text = "Aktivt";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(90, 158);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Spara";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // CreateCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(207, 199);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.activeLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.zipLbl);
            this.Controls.Add(this.streetLbl);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.streetBox);
            this.Controls.Add(this.nameBox);
            this.Name = "CreateCompanyForm";
            this.Text = "CreateCompanyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.TextBox streetBox;
		private System.Windows.Forms.TextBox zipBox;
		private System.Windows.Forms.TextBox cityBox;
		private System.Windows.Forms.CheckBox activeCheckBox;
		private System.Windows.Forms.Label streetLbl;
		private System.Windows.Forms.Label zipLbl;
		private System.Windows.Forms.Label cityLbl;
		private System.Windows.Forms.Label activeLbl;
		private System.Windows.Forms.Button saveBtn;
	}
}