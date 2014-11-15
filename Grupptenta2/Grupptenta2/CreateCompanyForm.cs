using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestClasses;
using CodeBase;

namespace Grupptenta2
{
	public partial class CreateCompanyForm : Form
	{
		private static CompanyManager _companyManager;

		public CreateCompanyForm(CompanyManager companyManager)
		{
			_companyManager = companyManager;

			InitializeComponent();
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			_companyManager.CreateCompany(nameBox.Text);
			int indexOfNewCompany = _companyManager.Companies.Count - 1;
			Company company = _companyManager.Companies[indexOfNewCompany];

			company.Location.Street = streetBox.Text;
			company.Location.ZipCode = zipBox.Text;
			company.Location.City = cityBox.Text;
			company.IsActive = activeCheckBox.Checked;
		}

        private void CreateCompanyForm_Load(object sender, EventArgs e)
        {

        }
	}
}
