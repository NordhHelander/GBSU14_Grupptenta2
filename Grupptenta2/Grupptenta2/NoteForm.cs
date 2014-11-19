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
	public partial class NoteForm : Form
	{
		public NoteForm(Note note)
		{
			InitializeComponent();
			dateTimeBox.Text = note.NoteDate.ToString();
			textBox.Text = note.Text;
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
