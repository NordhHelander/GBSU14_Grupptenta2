namespace TestForms
{
    partial class PersonForm
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
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.llb_Company = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.Location = new System.Drawing.Point(12, 9);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(35, 13);
            this.lb_FirstName.TabIndex = 0;
            this.lb_FirstName.Text = "label1";
            // 
            // llb_Company
            // 
            this.llb_Company.AutoSize = true;
            this.llb_Company.Location = new System.Drawing.Point(12, 36);
            this.llb_Company.Name = "llb_Company";
            this.llb_Company.Size = new System.Drawing.Size(55, 13);
            this.llb_Company.TabIndex = 1;
            this.llb_Company.TabStop = true;
            this.llb_Company.Text = "linkLabel1";
            this.llb_Company.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Company_LinkClicked);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.llb_Company);
            this.Controls.Add(this.lb_FirstName);
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.LinkLabel llb_Company;
    }
}