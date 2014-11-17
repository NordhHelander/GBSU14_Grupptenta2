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
	public partial class CreateEventForm : Form
	{
		private static Project _project;

		public CreateEventForm(Project project)
		{
			_project = project;

			InitializeComponent();
			this.Text = "Skapa händelse";
		}
	}
}
