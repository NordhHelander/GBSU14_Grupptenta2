using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeBase;

namespace TestForms
{
    public partial class TestForm : Form
    {
        public List<Company> Companies { get; set; }
        
        public TestForm()
        {
            InitializeComponent();
            Companies = new List<Company>();
            Companies.Add(new Company("Volvo Cars AB"));
            Companies.Add(new Company("Apple, inc."));
            //Companies[0].Employees.Add(new Person("Bertil Larsson", Companies[0]));
            //Companies[0].Employees.Add(new Person("Ceasar Oscarsson", Companies[0]));
            //Companies[1].Employees.Add(new Person("David Lind", Companies[1]));
            //Companies[1].Employees.Add(new Person("Eric Gates", Companies[1]));

            lstBx_Companies.DataSource = Companies;
            lstBx_Companies.DisplayMember = "Name";
        }

        public void lstBx_Companies_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBx_Name.Text = ((Company)lstBx_Companies.SelectedItem).Name.ToString();
            txtBx_Id.Text = ((Company)lstBx_Companies.SelectedItem).Id.ToString();
            chBx_IsActive.Checked = ((Company)lstBx_Companies.SelectedItem).IsActive;

            lstBx_Employees.DataSource = ((Company)lstBx_Companies.SelectedItem).Employees;
            lstBx_Employees.DisplayMember = "FirstName";
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            Company employeeCompany = ((Company)lstBx_Companies.SelectedItem);
            //employeeCompany.Employees.Add(new Person("Adam Svensson", employeeCompany));
        }

        private void lstBx_Employees_DoubleClick(object sender, EventArgs e)
        {
            Person selectedEmployee = ((Person)((ListBox)sender).SelectedItem);

            PersonForm employeeForm = new PersonForm(selectedEmployee);
            employeeForm.Show();
        }

    }
}
