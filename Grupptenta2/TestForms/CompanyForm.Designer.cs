namespace TestForms
{
    partial class CompanyForm
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
            this.lb_CompanyName = new System.Windows.Forms.Label();
            this.lstBx_Employees = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_CompanyName
            // 
            this.lb_CompanyName.AutoSize = true;
            this.lb_CompanyName.Location = new System.Drawing.Point(13, 13);
            this.lb_CompanyName.Name = "lb_CompanyName";
            this.lb_CompanyName.Size = new System.Drawing.Size(35, 13);
            this.lb_CompanyName.TabIndex = 0;
            this.lb_CompanyName.Text = "label1";
            // 
            // lstBx_Employees
            // 
            this.lstBx_Employees.FormattingEnabled = true;
            this.lstBx_Employees.Location = new System.Drawing.Point(13, 30);
            this.lstBx_Employees.Name = "lstBx_Employees";
            this.lstBx_Employees.Size = new System.Drawing.Size(120, 95);
            this.lstBx_Employees.TabIndex = 1;
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstBx_Employees);
            this.Controls.Add(this.lb_CompanyName);
            this.Name = "CompanyForm";
            this.Text = "CompanyForm";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CompanyName;
        private System.Windows.Forms.ListBox lstBx_Employees;
    }
}