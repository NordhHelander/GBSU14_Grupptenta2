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
		private Note _note;

		public CreateNoteForm(BindingList<Note> notes)
		{
			_notes = notes;
			_note = new Note();
			_notes.Add(_note);
			InitializeComponent();
			this.Text = "Ny anteckning";
		}

		public CreateNoteForm(Note note)
		{
			_note = note;
			InitializeComponent();
			this.Text = "Ändra anteckning";
			noteBox.Text = _note.Text;
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			_note.NoteDate = DateTime.Now;
			_note.Text = noteBox.Text;

			this.Close();
		}
	}
}
