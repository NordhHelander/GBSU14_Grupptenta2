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
	public partial class SearchBox : UserControl
	{
		public delegate void SearchEventHandler(object sender, SearchHandlerEventArgs e);
		public delegate void CreateEventHandler();
		public delegate void ChoiceBoxSelectionChangedEventHandler(object sender, ChoiceBoxSelectionChangedHandlerEventArgs e);

		public event SearchEventHandler OnSearch;
		public event CreateEventHandler OnCreate;
		public event ChoiceBoxSelectionChangedEventHandler OnSelectionChanged;

		public SearchBox()
		{
			InitializeComponent();
		}

		public void SetData(Object dataSource, string displayMember)
		{
			choiceBox.DataSource = null;
			choiceBox.DataSource = dataSource;
			choiceBox.DisplayMember = displayMember;
		}

		public void SetHeader(string header)
		{
			headerLbl.Text = header;
		}

		private void searchBtn_Click(object sender, EventArgs e)
		{
			if (OnSearch != null)
				OnSearch(sender, new SearchHandlerEventArgs(searchField.Text));
		}

		private void createBtn_Click(object sender, EventArgs e)
		{
			if (OnCreate != null)
				OnCreate();
		}

		private void choiceBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (OnSelectionChanged != null)
				OnSelectionChanged(sender, new ChoiceBoxSelectionChangedHandlerEventArgs(choiceBox.SelectedItem));
		}
	}

	public class SearchHandlerEventArgs : EventArgs
	{
		public string SearchText { get; set; }
		public SearchHandlerEventArgs(string searchText)
		{
			SearchText = searchText;
		}
	}

	public class ChoiceBoxSelectionChangedHandlerEventArgs : EventArgs
	{
		public object ChosenItem { get; set; }
		public ChoiceBoxSelectionChangedHandlerEventArgs(object chosenItem)
		{
			ChosenItem = chosenItem;
		}
	}
}