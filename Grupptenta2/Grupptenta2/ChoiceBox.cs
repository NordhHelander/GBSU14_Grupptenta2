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
		public delegate void DoubleClickEventHandler(object sender, DoubleClickHandlerEventArgs e);
		public delegate void ListBoxSelectionChangedEventHandler(object sender, ListBoxSelectionChangedHandlerEventArgs e);

		public event GoToEventHandler OnGoTo;
		public event AddItemEventHandler OnAdd;
		public event DoubleClickEventHandler OnDoubleClickChoice;
		public event ListBoxSelectionChangedEventHandler OnSelectionChanged;

		public ChoiceBox()
		{
			InitializeComponent();
		}

		public void SetHeader(string header)
		{
			headerLbl.Text = header;
		}

		public void SetButtonTexts(string goToChoiceBtnText, string actionBtnText)
		{
			goToChoiceBtn.Text = goToChoiceBtnText;
			actionBtn.Text = actionBtnText;
		}

		public void SetData(Object dataSource, string displayMember)
		{
			listBox.DataSource = null;
			listBox.DataSource = dataSource;
			listBox.DisplayMember = displayMember;
		}

		public void HideActionBtn()
		{
			actionBtn.Hide();
		}

		public void HideGoToChoiceBtn()
		{
			goToChoiceBtn.Visible = false;
			actionBtn.Location = new Point(160, 21);
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

		private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (OnDoubleClickChoice != null)
			{
				OnDoubleClickChoice(sender, new DoubleClickHandlerEventArgs(listBox.SelectedItem));
			}
		}

		private void listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (OnSelectionChanged != null)
			{
				OnSelectionChanged(sender, new ListBoxSelectionChangedHandlerEventArgs(listBox.SelectedItem));
			}
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

	public class DoubleClickHandlerEventArgs : EventArgs
	{
		public object ChosenItem { get; set; }
		public DoubleClickHandlerEventArgs(object chosenItem)
		{
			ChosenItem = chosenItem;
		}
	}

	public class ListBoxSelectionChangedHandlerEventArgs : EventArgs
	{
		public object ChosenItem { get; set; }
		public ListBoxSelectionChangedHandlerEventArgs(object chosenItem)
		{
			ChosenItem = chosenItem;
		}
	}
}
