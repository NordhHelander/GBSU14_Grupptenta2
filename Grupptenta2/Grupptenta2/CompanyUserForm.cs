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

namespace Grupptenta2
{
	public partial class CompanyUserForm : UserControl
	{
		public delegate void SaveCompanyChangesEventHandler(object sender, SaveCompanyChangesHandlerEventArgs e);
		public delegate void ClosePopUpEventHandler();

		public event SaveCompanyChangesEventHandler OnSaveCompanyChanges;
		public event ClosePopUpEventHandler OnClosePopUp;

		private static Company _company;
	
		public CompanyUserForm()
		{
			InitializeComponent();
		}

		public void HidePopUpBtn()
		{
			popUpBtn.Visible = false;
		}

		public void SetCompanyInfo(Company company)
		{
			_company = company;

			nameBox.Text = _company.Name;
			idBox.Text = _company.Id.ToString();
			streetBox.Text = _company.Location.Street;
			zipBox.Text = _company.Location.ZipCode;
			cityBox.Text = _company.Location.City;
			activeCheckBox.Checked = _company.IsActive;

			projectBox.DataSource = _company.Projects;
			projectBox.DisplayMember = "Name";
			contactBox.DataSource = _company.Employees;
			contactBox.DisplayMember = "Person";
		}
		private void editSaveBtn_Click(object sender, EventArgs e)
		{
			if (editSaveBtn.Text == "Redigera")
			{
				nameBox.ReadOnly = false;
				idBox.ReadOnly = false;
				streetBox.ReadOnly = false;
				zipBox.ReadOnly = false;
				cityBox.ReadOnly = false;
				activeCheckBox.Enabled = true;

				editSaveBtn.Text = "Spara";
			}
			else if (editSaveBtn.Text == "Spara")
			{
				nameBox.ReadOnly = true;
				idBox.ReadOnly = true;
				streetBox.ReadOnly = true;
				zipBox.ReadOnly = true;
				cityBox.ReadOnly = true;
				activeCheckBox.Enabled = false;

				if (OnSaveCompanyChanges != null)
					OnSaveCompanyChanges(sender, new SaveCompanyChangesHandlerEventArgs(nameBox.Text, int.Parse(idBox.Text), streetBox.Text, zipBox.Text, cityBox.Text, activeCheckBox.Checked));

				editSaveBtn.Text = "Redigera";
			}
		}

		private void popUpBtn_Click(object sender, EventArgs e)
		{
			CompanyPopUp companyPopUp = new CompanyPopUp(_company);
			companyPopUp.ShowDialog();
			SetCompanyInfo(_company);

			if (OnClosePopUp != null)
				OnClosePopUp();
		}
	}

	public class SaveCompanyChangesHandlerEventArgs : EventArgs
	{
		public string Name { get; set; }
		public int Id { get; set; }
		public string Street { get; set; }
		public string ZipCode { get; set; }
		public string City { get; set; }
		public bool IsActive { get; set; }

		public SaveCompanyChangesHandlerEventArgs(string name, int id, string street, string zipCode, string city, bool isActive)
		{
			Name = name;
			Id = id;
			Street = street;
			ZipCode = zipCode;
			City = city;
			IsActive = isActive;
		}
	}
}
