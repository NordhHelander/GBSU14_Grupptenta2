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
		public delegate void AddItemEventHandler();
		public delegate void DoubleClickEventHandler(object sender, DoubleClickHandlerEventArgs e);
		public delegate void ListBoxSelectionChangedEventHandler(object sender, ListBoxSelectionChangedHandlerEventArgs e);

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

		public void SetButtonTexts(string actionBtnText)
		{
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
