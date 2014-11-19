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
            this.personControl = new Grupptenta2.PersonUserControl();
            this.SuspendLayout();
            // 
            // personControl
            // 
            this.personControl.BackColor = System.Drawing.Color.White;
            this.personControl.Location = new System.Drawing.Point(12, 12);
            this.personControl.Name = "personControl";
            this.personControl.Size = new System.Drawing.Size(414, 467);
            this.personControl.TabIndex = 0;
            // 
            // CreatePersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 493);
            this.Controls.Add(this.personControl);
            this.Name = "CreatePersonForm";
            this.ShowInTaskbar = false;
            this.Text = "CreatePersonForm";
            this.ResumeLayout(false);

		}

		#endregion

		private PersonUserControl personControl;

	}
}