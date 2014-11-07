namespace TestForms
{
    partial class TestForm
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
            this.lstBx_Companies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBx_Companies
            // 
            this.lstBx_Companies.FormattingEnabled = true;
            this.lstBx_Companies.Location = new System.Drawing.Point(13, 13);
            this.lstBx_Companies.Name = "lstBx_Companies";
            this.lstBx_Companies.Size = new System.Drawing.Size(120, 95);
            this.lstBx_Companies.TabIndex = 0;
            this.lstBx_Companies.SelectedIndexChanged += new System.EventHandler(this.lstBx_Companies_SelectedIndexChanged);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstBx_Companies);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBx_Companies;
    }
}

