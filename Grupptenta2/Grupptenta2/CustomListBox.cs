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
	public partial class CustomListBox : UserControl
	{
		public delegate void GoToEventHandler(object sender, GoToHandlerEventArgs e);
		public event GoToEventHandler OnGoTo;

		public CustomListBox()
		{
			InitializeComponent();
		}

		public void SetData(string header, Object dataSource, string displayMember)
		{
			headerBox.Text = header;
			listBox.DataSource = dataSource;
			listBox.DisplayMember = displayMember;
		}

		private void goToChoiceBtn_Click(object sender, EventArgs e)
		{
			if (OnGoTo != null)
				OnGoTo(sender, new GoToHandlerEventArgs(listBox.SelectedItem));
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
