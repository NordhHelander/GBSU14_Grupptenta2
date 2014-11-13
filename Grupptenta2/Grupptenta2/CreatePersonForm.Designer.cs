namespace Grupptenta2
{
	partial class CreatePersonForm
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
			this.personInfoBox = new Grupptenta2.PersonInfoBox();
			this.SuspendLayout();
			// 
			// personInfoBox
			// 
			this.personInfoBox.Location = new System.Drawing.Point(21, 10);
			this.personInfoBox.Name = "personInfoBox";
			this.personInfoBox.Size = new System.Drawing.Size(240, 438);
			this.personInfoBox.TabIndex = 0;
			// 
			// CreatePersonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 640);
			this.Controls.Add(this.personInfoBox);
			this.Name = "CreatePersonForm";
			this.Text = "CreatePersonForm";
			this.ResumeLayout(false);

		}

		#endregion

		private PersonInfoBox personInfoBox;
	}
}