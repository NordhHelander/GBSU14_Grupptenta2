namespace Grupptenta2
{
	partial class PersonPopUp
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
			this.personPnl = new System.Windows.Forms.Panel();
			this.relationBox = new Grupptenta2.CustomListBox();
			this.projectBox = new Grupptenta2.CustomListBox();
			this.personInfoBox = new Grupptenta2.PersonInfoBox();
			this.personPnl.SuspendLayout();
			this.SuspendLayout();
			// 
			// personPnl
			// 
			this.personPnl.BackColor = System.Drawing.Color.White;
			this.personPnl.Controls.Add(this.relationBox);
			this.personPnl.Controls.Add(this.projectBox);
			this.personPnl.Controls.Add(this.personInfoBox);
			this.personPnl.Location = new System.Drawing.Point(9, 9);
			this.personPnl.Margin = new System.Windows.Forms.Padding(0);
			this.personPnl.Name = "personPnl";
			this.personPnl.Size = new System.Drawing.Size(685, 675);
			this.personPnl.TabIndex = 11;
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
			// personInfoBox
			// 
			this.personInfoBox.Location = new System.Drawing.Point(3, 3);
			this.personInfoBox.Name = "personInfoBox";
			this.personInfoBox.Size = new System.Drawing.Size(240, 669);
			this.personInfoBox.TabIndex = 0;
			// 
			// PersonPopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(703, 694);
			this.Controls.Add(this.personPnl);
			this.Name = "PersonPopUp";
			this.Text = "PersonPopUp";
			this.personPnl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel personPnl;
		private CustomListBox relationBox;
		private CustomListBox projectBox;
		private PersonInfoBox personInfoBox;
	}
}