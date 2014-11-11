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
    public partial class PersonForm : Form
    {
        Person Employee; 
        //Company Employer; 
        
        public PersonForm(Person selectedEmployee)
        {
            Employee = selectedEmployee;
            //Employer = selectedEmployee.Employer;
            InitializeComponent();
            
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            this.Text = Employee.FirstName;
            lb_FirstName.Text = Employee.FirstName;
            //llb_Company.Text = Employee.Employer.Name;
        }

        private void llb_Company_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //CompanyForm companyForm = new CompanyForm(Employer);
            //companyForm.Show();
        }
    }
}
