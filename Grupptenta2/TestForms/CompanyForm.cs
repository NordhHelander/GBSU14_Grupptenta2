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

namespace TestForms
{
    public partial class CompanyForm : Form
    {
        public Company CurrentCompany { get; set; }
        
        public CompanyForm(Company selectedCompany)
        {
            CurrentCompany = selectedCompany;

            InitializeComponent();

            lb_CompanyName.Text = CurrentCompany.Name;
            lstBx_Employees.DataSource = CurrentCompany.Employees;
            lstBx_Employees.DisplayMember = "FirstName";
            this.Text = CurrentCompany.Name;
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
