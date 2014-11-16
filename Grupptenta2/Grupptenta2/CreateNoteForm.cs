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
using TestClasses;

namespace Grupptenta2
{
	public partial class CreateNoteForm : Form
	{
		private static BindingList<Note> _notes;

		public CreateNoteForm(BindingList<Note> notes)
		{
			_notes = notes;

			InitializeComponent();
			this.Text = "Ny anteckning";
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			Note note = new Note();
			// Se till att author blir inloggad personal.
			note.NoteDate = DateTime.Now;
			note.Text = noteBox.Text;
			note.IsPublic = isPublicCheckBox.Checked;

			_notes.Add(note);
			this.Close();
		}
	}
}
