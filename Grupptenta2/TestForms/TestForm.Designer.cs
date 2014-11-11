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
            this.txtBx_Name = new System.Windows.Forms.TextBox();
            this.txtBx_Id = new System.Windows.Forms.TextBox();
            this.chBx_IsActive = new System.Windows.Forms.CheckBox();
            this.lstBx_Employees = new System.Windows.Forms.ListBox();
            this.btn_addEmployee = new System.Windows.Forms.Button();
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
            // txtBx_Name
            // 
            this.txtBx_Name.Location = new System.Drawing.Point(140, 13);
            this.txtBx_Name.Name = "txtBx_Name";
            this.txtBx_Name.Size = new System.Drawing.Size(163, 20);
            this.txtBx_Name.TabIndex = 1;
            // 
            // txtBx_Id
            // 
            this.txtBx_Id.Location = new System.Drawing.Point(139, 39);
            this.txtBx_Id.Name = "txtBx_Id";
            this.txtBx_Id.Size = new System.Drawing.Size(163, 20);
            this.txtBx_Id.TabIndex = 1;
            // 
            // chBx_IsActive
            // 
            this.chBx_IsActive.AutoSize = true;
            this.chBx_IsActive.Location = new System.Drawing.Point(139, 66);
            this.chBx_IsActive.Name = "chBx_IsActive";
            this.chBx_IsActive.Size = new System.Drawing.Size(66, 17);
            this.chBx_IsActive.TabIndex = 2;
            this.chBx_IsActive.Text = "Is active";
            this.chBx_IsActive.UseVisualStyleBackColor = true;
            // 
            // lstBx_Employees
            // 
            this.lstBx_Employees.FormattingEnabled = true;
            this.lstBx_Employees.Location = new System.Drawing.Point(309, 12);
            this.lstBx_Employees.Name = "lstBx_Employees";
            this.lstBx_Employees.Size = new System.Drawing.Size(120, 95);
            this.lstBx_Employees.TabIndex = 0;
            this.lstBx_Employees.SelectedIndexChanged += new System.EventHandler(this.lstBx_Companies_SelectedIndexChanged);
            this.lstBx_Employees.DoubleClick += new System.EventHandler(this.lstBx_Employees_DoubleClick);
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.Location = new System.Drawing.Point(309, 114);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(58, 23);
            this.btn_addEmployee.TabIndex = 3;
            this.btn_addEmployee.Text = "Add";
            this.btn_addEmployee.UseVisualStyleBackColor = true;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 272);
            this.Controls.Add(this.btn_addEmployee);
            this.Controls.Add(this.chBx_IsActive);
            this.Controls.Add(this.txtBx_Id);
            this.Controls.Add(this.txtBx_Name);
            this.Controls.Add(this.lstBx_Employees);
            this.Controls.Add(this.lstBx_Companies);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBx_Companies;
        private System.Windows.Forms.TextBox txtBx_Name;
        private System.Windows.Forms.TextBox txtBx_Id;
        private System.Windows.Forms.CheckBox chBx_IsActive;
        private System.Windows.Forms.ListBox lstBx_Employees;
        private System.Windows.Forms.Button btn_addEmployee;
    }
}

