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
			this.personControl = new Grupptenta2.PersonUserControl();
			this.relationBox = new Grupptenta2.ChoiceBox();
			this.projectBox = new Grupptenta2.ChoiceBox();
			this.SuspendLayout();
			// 
			// personControl
			// 
			this.personControl.BackColor = System.Drawing.Color.White;
			this.personControl.Location = new System.Drawing.Point(12, 12);
			this.personControl.Name = "personControl";
			this.personControl.Size = new System.Drawing.Size(415, 487);
			this.personControl.TabIndex = 0;
			// 
			// relationBox
			// 
			this.relationBox.BackColor = System.Drawing.Color.White;
			this.relationBox.Location = new System.Drawing.Point(455, 249);
			this.relationBox.Name = "relationBox";
			this.relationBox.Size = new System.Drawing.Size(241, 175);
			this.relationBox.TabIndex = 13;
			// 
			// projectBox
			// 
			this.projectBox.BackColor = System.Drawing.Color.White;
			this.projectBox.Location = new System.Drawing.Point(455, 22);
			this.projectBox.Name = "projectBox";
			this.projectBox.Size = new System.Drawing.Size(241, 175);
			this.projectBox.TabIndex = 14;
			// 
			// PersonPopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(710, 550);
			this.Controls.Add(this.projectBox);
			this.Controls.Add(this.relationBox);
			this.Controls.Add(this.personControl);
			this.Name = "PersonPopUp";
			this.Text = "PersonPopUp";
			this.ResumeLayout(false);

		}

		#endregion

		private PersonUserControl personControl;
		private ChoiceBox relationBox;
		private ChoiceBox projectBox;
	}
}