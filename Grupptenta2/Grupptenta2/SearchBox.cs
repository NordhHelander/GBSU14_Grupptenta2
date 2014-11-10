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
		public delegate void OrderByEventHandler(object sender, OrderByHandlerEventArgs e);

		public event SearchEventHandler OnSearch;
		public event OrderByEventHandler OnOrderByChanged;

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
	}

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
}