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
        private ProjectEvent _event;
        private static BindingList<Note> _tempNotes;
		private static BindingList<Person> _tempParticipants;

		public CreateEventForm(Project project)
		{
			_project = project;
            _event = new ProjectEvent();
            _tempNotes = new BindingList<Note>();
            _tempParticipants = new BindingList<Person>();

			InitializeComponent();
			this.Text = "Skapa händelse";
			eventCreationContainer.Panel2.Hide();
			personList.DataSource = _project.Roles;
			personList.DisplayMember = "Person";
		}
         
		private void isMeetingCheckBox_CheckedChanged(object sender, EventArgs e)
		{
            if (isMeetingCheckBox.Checked == true)
            {
                eventCreationContainer.Panel2.Show();
            }
            else
            {
                eventCreationContainer.Panel2.Hide();
            }
		}

        private void addNoteBtn_Click(object sender, EventArgs e)
        {
            Note newNote = new Note();
            newNote.NoteDate = DateTime.Now;
            newNote.Text = noteBox.Text;
            _tempNotes.Add(newNote);
            noteList.DataSource = _tempNotes;
            noteList.DisplayMember = "Note";
            noteBox.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _event = new ProjectEvent();
            _event.Name = nameBox.Text;
            _event.StartDate = startPicker.Value;
            _event.EndDate = stopPicker.Value;
            _event.Notes = _tempNotes;
            
            if (isMeetingCheckBox.Checked)
            {
                Address meetingLocation = new Address();
                meetingLocation.Street = streetTxtBx.Text;
                meetingLocation.ZipCode = zipTxtBx.Text;
                meetingLocation.City = cityTxtBx.Text;
                
                _event.Location = meetingLocation;
                _event.Participants = _tempParticipants;
            }
            _project.ProjectJournal.Events.Add(_event);
            this.Close();
        }

        private void noteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void getAddressBtn_Click(object sender, EventArgs e)
        {

        }

        private void addParticipantBtn_Click(object sender, EventArgs e)
        {
            if (_tempParticipants == null)
                _tempParticipants = new BindingList<Person>();
            
            Person newParticipant = (Person)personList.SelectedItem;

            _tempParticipants.Add(newParticipant);

            participantList.DataSource = _tempParticipants;
            participantList.DisplayMember = "Name";
        }

        private void removeNoteBtn_Click(object sender, EventArgs e)
        {
            Note selectedNote = (Note)noteList.SelectedItem;
            if (selectedNote != null)
            {
                _project.ProjectJournal.Notes.Remove(selectedNote);   
            }
        }

        private void removeParticipantBtn_Click(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)participantList.SelectedItem;
            if (selectedPerson != null)
            {
                _tempParticipants.Remove(selectedPerson);
            }
        }

	}
}

