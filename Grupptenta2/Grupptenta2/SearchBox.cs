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
		// EVENTS
		public event SearchEventHandler OnSearch;
		public event OrderByEventHandler OnOrderByChanged;
		public event GoToChoiceEventHandler OnGoToChoice;

		public SearchBox()
		{
			InitializeComponent();
		}

		public List<string> OrderBy_Datasource
		{
			set { orderByBox.DataSource = value; }
		}

		public string SearchText
		{
			set { searchField.Text = value; }
		}

		private void searchBtn_Click(object sender, EventArgs e)
		{
			if (OnSearch != null)
				OnSearch(sender, new SearchHandlerEventArgs(searchField.Text));
		}

		private void orderBy_Click(object sender, EventArgs e)
		{
			if (OnOrderByChanged != null)
				OnOrderByChanged(sender, new OrderByHandlerEventArgs((string)orderByBox.SelectedValue));
		}

		private void goToChoiceBtn_Click(object sender, EventArgs e)
		{
			if (OnGoToChoice != null)
			{
				OnGoToChoice(sender, new GoToChoiceHandlerEventArgs(listBox.SelectedItem, listBox.DataSource));
			}
		}
	}

	// DELEGATER
	public delegate void SearchEventHandler(object sender, SearchHandlerEventArgs e);
	public delegate void OrderByEventHandler(object sender, OrderByHandlerEventArgs e);
	public delegate void GoToChoiceEventHandler(object sender, OrderByHandlerEventArgs e);

	// DATABÄRANDE EVENTARGS-KLASSER
	public class SearchHandlerEventArgs : EventArgs
	{
		public string SearchText { get; set; }
		public SearchHandlerEventArgs(string searchText)
		{
			SearchText = searchText;
		}
	}

	public class OrderByHandlerEventArgs : EventArgs
	{
		public string OrderByValue { get; set; }
		public OrderByHandlerEventArgs(string orderByValue)
		{
			OrderByValue = orderByValue;
		}
	}

	public class GoToChoiceHandlerEventArgs<object, object> : EventArgs
	{
		private object _listItem;
		private List<object> _list;

		public object GetListItem()
		{
			return _listItem;
		}

		public object GetList()
		{
			return _list;
		}

		public GoToChoiceHandlerEventArgs(object listItem, List<object> list)
		{
			this._listItem = listItem;
			this._list = list;
		}
	}
}