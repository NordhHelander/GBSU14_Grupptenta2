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

namespace Grupptenta2
{
	public partial class BirthdayAlertForm : Form
	{
		public BirthdayAlertForm(List<Person> birthdayPeople)
		{
			InitializeComponent();

			birthdayList.DataSource = birthdayPeople;
			birthdayList.DisplayMember = "Person";
		}

		private void birthdayList_SelectedIndexChanged(object sender, EventArgs e)
		{
			Person selectedPerson = (Person)birthdayList.SelectedItem;
			int age = int.Parse(DateTime.Now.Year.ToString()) - int.Parse(selectedPerson.Birthdate.Year.ToString());
			nameTurnsAgeLbl.Text = selectedPerson.ToString() + " fyller " + age + " år idag.";
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
