using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeBase;
using TestClasses;

namespace Grupptenta2
{
	public partial class CompanyUserControl : UserControl
	{
		public delegate void SaveCompanyChangesEventHandler();
		public delegate void ClosePopUpEventHandler();

		public event SaveCompanyChangesEventHandler OnSaveCompanyChanges;
		public event ClosePopUpEventHandler OnClosePopUp;

		private static Company _company;
		private bool _newCompany;
		private CompanyManager _companyManager;
	
		public CompanyUserControl()
		{
			InitializeComponent();
		}

		public void HidePopUpBtn()
		{
			popUpBtn.Visible = false;
		}

		public void SetupForCreateCompany(CompanyManager companyManager)
		{
			_newCompany = true;
			_companyManager = companyManager;
			nameBox.Text = "Företagets namn";

		}
		public void SetCompanyInfo(Company company)
		{
			_newCompany = false;
			_company = company;

			nameBox.Text = _company.Name;
			idBox.Text = _company.Id.ToString();
			streetBox.Text = _company.Location.Street;
			zipBox.Text = _company.Location.ZipCode;
			cityBox.Text = _company.Location.City;
			activeCheckBox.Checked = _company.IsActive;
		}
		private void saveBtn_Click(object sender, EventArgs e)
		{
			if (_newCompany)
			{
				_companyManager.CreateCompany(nameBox.Text);
				_company = _companyManager.Companies[_companyManager.Companies.Count - 1];
			}

			_company.Location.Street = streetBox.Text;
			_company.Location.ZipCode = zipBox.Text;
			_company.Location.City = cityBox.Text;
			_company.IsActive = activeCheckBox.Checked;

				if (OnSaveCompanyChanges != null)
					OnSaveCompanyChanges();
		}

		private void popUpBtn_Click(object sender, EventArgs e)
		{
			if (_company != null)
			{
				CompanyPopUp companyPopUp = new CompanyPopUp(_company);
				companyPopUp.ShowDialog();
				SetCompanyInfo(_company);
			}

			if (OnClosePopUp != null)
				OnClosePopUp();
		}
	}
}
