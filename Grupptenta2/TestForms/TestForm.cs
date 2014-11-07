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
            Companies.Add(new Company("Volvo"));
            Companies.Add(new Company("Saab"));
            
            lstBx_Companies.DataSource = Companies;
            lstBx_Companies.DisplayMember = "Name";
        }

        private void lstBx_Companies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
