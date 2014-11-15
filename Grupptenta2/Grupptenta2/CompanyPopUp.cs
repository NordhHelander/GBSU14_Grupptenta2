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
using TestClasses;

namespace Grupptenta2
{
	public partial class CompanyPopUp : Form
	{
		private static Company _company;

		public CompanyPopUp(Company company)
		{
			_company = company;

			InitializeComponent();
			this.Text = _company.Name;
			companyControl.SetCompanyInfo(_company);
			companyControl.OnSaveCompanyChanges += companyUserForm_OnSaveCompanyChanges;
			companyControl.HidePopUpBtn();
		}

		private void companyUserForm_OnSaveCompanyChanges(object sender, SaveCompanyChangesHandlerEventArgs e)
		{
			_company.Name = e.Name;
			_company.Id = e.Id;
			_company.Location.Street = e.Street;
			_company.Location.ZipCode = e.ZipCode;
			_company.Location.City = e.City;
			_company.IsActive = e.IsActive;

			this.Text = _company.Name;
		}
	}
}
