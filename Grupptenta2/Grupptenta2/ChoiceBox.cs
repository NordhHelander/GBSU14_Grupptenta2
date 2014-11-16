using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupptenta2
{
	public partial class ChoiceBox : UserControl
	{
		public delegate void GoToEventHandler(object sender, GoToHandlerEventArgs e);
		public delegate void AddItemEventHandler();

		public event GoToEventHandler OnGoTo;
		public event AddItemEventHandler OnAdd;

		public ChoiceBox()
		{
			InitializeComponent();
		}

		public void SetHeader(string header)
		{
			headerLbl.Text = header;
		}

		public void SetButtonTexts(string goToChoiceBtnText, string editListBtnText)
		{
			goToChoiceBtn.Text = goToChoiceBtnText;
			editListBtn.Text = editListBtnText;
		}

		public void SetData(Object dataSource, string displayMember)
		{
			listBox.DataSource = null;
			listBox.DataSource = dataSource;
			listBox.DisplayMember = displayMember;
		}

		private void goToChoiceBtn_Click(object sender, EventArgs e)
		{
			if (OnGoTo != null)
				OnGoTo(sender, new GoToHandlerEventArgs(listBox.SelectedItem));
		}

		private void editListBtn_Click(object sender, EventArgs e)
		{
			if (OnAdd != null)
				OnAdd();
		}
	}

	public class GoToHandlerEventArgs : EventArgs
	{
		public object ChosenItem { get; set; }

		public GoToHandlerEventArgs(object chosenItem)
		{
			ChosenItem = chosenItem;
		}
	}
}
