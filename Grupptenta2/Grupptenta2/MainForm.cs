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
	public partial class MainForm : Form
	{
		private static PersonManager _personManager;
		private static CompanyManager _companyManager;
		private static ProjectManager _projectManager;
		private static Person _selectedPerson;
		private static Company _selectedCompany;
		private static Project _selectedProject;
		private static ProjectEvent _selectedEvent;
		private static List<DateTime> _boldedDates;
		private static BindingList<ProjectEvent> _events;
		private static bool _isNewEvent;

		public MainForm()
		{
			_personManager = new PersonManager();
			_companyManager = new CompanyManager();
			_projectManager = new ProjectManager();

			InitializeComponent();
			//CreateMocks();
			SetEventMethods();
			CalendarBoldDates();
			ProjectTabSetup();
			ContactTabSetup();
			CompanyTabSetup();
			BirthdayAlert();
		}

		private void BirthdayAlert()
		{
			List<Person> birthdayList = _personManager.Persons.Where(p => p.Birthdate.Month.Equals(DateTime.Now.Month) && p.Birthdate.Day.Equals(DateTime.Now.Day)).ToList();
			if (birthdayList.Count > 0)
			{
				BirthdayAlertForm birthdayAlert = new BirthdayAlertForm(birthdayList);
				birthdayAlert.Show();
		}
		}

		private static void CreateMocks()
		{
			int numberOfCompanies = 3;
			int numberOfPersons = 12;
			int numberOfProjects = 6;

			for (int i = 0; i < numberOfCompanies; i++)
			{
				_companyManager.CreateCompany("Company no." + (i + 1));
			}

			for (int i = 0; i < numberOfPersons; i++)
			{
				_personManager.CreatePerson("Per" + (i + 1));
				_personManager.Persons[i].LastName = "Persson" + (i + 1);
				_personManager.Persons[i].Birthdate = DateTime.Today.AddYears(-(i + 1));
				_personManager.Persons[i].EmailAddress = "Per" + (i + 1) + "@" + "Persson" + (i + 1) + ".com";
			}

			for (int i = 0; i < numberOfProjects; i++)
			{
				_projectManager.CreateProject("Project no." + (i + 1));
				_projectManager.Projects[i].Name = "Project no." + (i + 1);
				_projectManager.Projects[i].ProjectJournal = new Journal();
			}

			_personManager.Persons[0].Birthdate = new DateTime(1984, 11, 19);
			_personManager.Persons[0].FirstName = "Really Long Name Sally";
			_personManager.Persons[1].Birthdate = new DateTime(1985, 11, 19);
			_personManager.Persons[2].Birthdate = new DateTime(1987, 10, 19);
			_personManager.Persons[3].Birthdate = new DateTime(1984, 12, 19);
			_personManager.Persons[4].Birthdate = new DateTime(1985, 12, 19);
			_personManager.Persons[5].Birthdate = new DateTime(1986, 12, 19);
			_personManager.Persons[6].Birthdate = new DateTime(1980, 10, 19);
			_personManager.Persons[7].Birthdate = new DateTime(1987, 10, 19);
			_personManager.Persons[8].Birthdate = new DateTime(1989, 10, 19);
			_personManager.Persons[9].Birthdate = new DateTime(1990, 11, 20);
			_personManager.Persons[10].Birthdate = new DateTime(1975, 11, 20);
			_personManager.Persons[11].Birthdate = new DateTime(1930, 11, 20);

			_companyManager.Companies[0].Employees.Add(_personManager.Persons[0]);
			_companyManager.Companies[0].Employees.Add(_personManager.Persons[1]);
			_companyManager.Companies[0].Employees.Add(_personManager.Persons[2]);
			_companyManager.Companies[0].Employees.Add(_personManager.Persons[3]);
			_companyManager.Companies[1].Employees.Add(_personManager.Persons[4]);
			_companyManager.Companies[1].Employees.Add(_personManager.Persons[5]);
			_companyManager.Companies[1].Employees.Add(_personManager.Persons[6]);
			_companyManager.Companies[1].Employees.Add(_personManager.Persons[7]);
			_companyManager.Companies[2].Employees.Add(_personManager.Persons[8]);
			_companyManager.Companies[2].Employees.Add(_personManager.Persons[9]);
			_companyManager.Companies[2].Employees.Add(_personManager.Persons[10]);
			_companyManager.Companies[2].Employees.Add(_personManager.Persons[11]);

			_companyManager.Companies[0].Projects.Add(_projectManager.Projects[0]);
			_companyManager.Companies[0].Projects[0].Roles.Add(_personManager.Persons[0]);
			_companyManager.Companies[0].Projects[0].Roles.Add(_personManager.Persons[1]);

			_companyManager.Companies[0].Projects.Add(_projectManager.Projects[1]);
			_companyManager.Companies[0].Projects[1].Roles.Add(_personManager.Persons[2]);
			_companyManager.Companies[0].Projects[1].Roles.Add(_personManager.Persons[3]);

			_companyManager.Companies[1].Projects.Add(_projectManager.Projects[2]);
			_companyManager.Companies[1].Projects[0].Roles.Add(_personManager.Persons[4]);
			_companyManager.Companies[1].Projects[0].Roles.Add(_personManager.Persons[5]);

			_companyManager.Companies[1].Projects.Add(_projectManager.Projects[3]);
			_companyManager.Companies[1].Projects[1].Roles.Add(_personManager.Persons[6]);
			_companyManager.Companies[1].Projects[1].Roles.Add(_personManager.Persons[7]);

			_companyManager.Companies[2].Projects.Add(_projectManager.Projects[4]);
			_companyManager.Companies[2].Projects[0].Roles.Add(_personManager.Persons[8]);
			_companyManager.Companies[2].Projects[0].Roles.Add(_personManager.Persons[9]);

			_companyManager.Companies[2].Projects.Add(_projectManager.Projects[5]);
			_companyManager.Companies[2].Projects[1].Roles.Add(_personManager.Persons[10]);
			_companyManager.Companies[2].Projects[1].Roles.Add(_personManager.Persons[11]);

			Note newNote1 = new Note();
			newNote1.NoteDate = DateTime.Now.AddDays(-1);
			newNote1.Text = "Presentationsmöte";
			Address newAddress1 = new Address();
			newAddress1.Street = "Merkurius";
			newAddress1.ZipCode = "111 11";
			newAddress1.City = "Mercury Town";
			ProjectEvent newMeeting1 = new ProjectEvent();
			newMeeting1.StartDate = new DateTime(2014, 11, 25, 14, 00, 00);
			newMeeting1.EndDate = new DateTime(2014, 11, 25, 15, 30, 00);
			newMeeting1.Name = "Testhändelse 1";
			newMeeting1.Notes.Add(newNote1);
			newMeeting1.Location = newAddress1;
			newMeeting1.Participants.Add(_personManager.Persons[0]);
			newMeeting1.Participants.Add(_personManager.Persons[1]);
			_companyManager.Companies[0].Projects[0].ProjectJournal.Events.Add(newMeeting1);

			Note newNote2 = new Note();
			newNote2.NoteDate = DateTime.Now.AddDays(-2);
			newNote2.Text = "Presentationsmöte";
			Address newAddress2 = new Address();
			newAddress2.Street = "Jupiter";
			newAddress2.ZipCode = "222 22";
			newAddress2.City = "Piter";
			ProjectEvent newMeeting2 = new ProjectEvent();
			newMeeting2.StartDate = new DateTime(2014, 11, 10, 11, 30, 00);
			newMeeting2.EndDate = new DateTime(2014, 11, 10, 13, 30, 00);
			newMeeting2.Name = "Testhändelse 2";
			newMeeting2.Notes.Add(newNote2);
			newMeeting2.Location = newAddress2;
			newMeeting2.Participants.Add(_personManager.Persons[2]);
			newMeeting2.Participants.Add(_personManager.Persons[3]);
			_companyManager.Companies[0].Projects[1].ProjectJournal.Events.Add(newMeeting2);
		}

		private void SetEventMethods()
		{
			// Contact
			contactChoiceBox.OnAdd += contactChoiceBox_OnAdd;
			contactChoiceBox.OnSelectionChanged += contactChoiceBox_OnSelectionChanged;

			contactControl.OnSavePersonChanges += contactControl_OnSavePersonChanges;
			contactControl.OnDoubleClickNote += contactControl_OnDoubleClickNote;

			contactRelationBox.OnAdd += contactRelationBox_OnAdd;
			contactRelationBox.OnDoubleClickChoice += contactRelationBox_OnDoubleClickChoice;
			contactRelationBox.OnSelectionChanged += contactRelationBox_OnSelectionChanged;

			contactProjectBox.OnDoubleClickChoice += contactProjectBox_OnDoubleClickChoice;
			contactProjectBox.OnSelectionChanged += contactProjectBox_OnSelectionChanged;
			contactProjectBox.OnAdd += contactProjectBox_OnAdd;

			//Company
			companyChoiceBox.OnSelectionChanged += companyChoiceBox_OnSelectionChanged;
			companyChoiceBox.OnAdd += companyChoiceBox_OnAdd;

			companyControl.OnSaveCompanyChanges += companyControl_OnSaveCompanyChanges;

			companyProjectBox.OnAdd += companyProjectBox_OnAdd;
			companyProjectBox.OnDoubleClickChoice += companyProjectBox_OnDoubleClick;
			companyProjectBox.OnSelectionChanged += companyProjectBox_OnSelectionChanged;

			companyEmployeeBox.OnAdd += companyEmployeeBox_OnAdd;
			companyEmployeeBox.OnDoubleClickChoice += companyEmployeeBox_OnDoubleClick;
			companyEmployeeBox.OnSelectionChanged += companyEmployeeBox_OnSelectionChanged;

			// Project
			projectChoiceBox.OnAdd += projectChoiceBox_OnAdd;
			projectChoiceBox.OnSelectionChanged += projectChoiceBox_OnSelectionChanged;

			projectParticipantBox.OnAdd += projectParticipantBox_OnRemove;
			projectParticipantBox.OnDoubleClickChoice += projectParticipantBox_OnDoubleClickChoice;
			projectParticipantBox.OnSelectionChanged += projectParticipantBox_OnSelectionChanged;

			projectAvailableParticipantsBox.OnAdd += projectAvailableParticipantsBox_OnAdd;

			projectEventBox.OnAdd += projectEventBox_OnAdd;
			projectEventBox.OnDoubleClickChoice += projectEventBox_OnDoubleClickChoice;
			projectEventBox.OnSelectionChanged += projectEventBox_OnSelectionChanged;

			projectNoteBox.OnAdd += projectNoteBox_OnAdd;
			projectNoteBox.OnDoubleClickChoice += projectNoteBox_OnDoubleClickChoice;
		}

		#region "Calendar"
		private void CalendarBoldDates()
		{
			_boldedDates = new List<DateTime>();

			for (int i = 0; i < _projectManager.Projects.Count; i++)
			{
				for (int j = 0; j < _projectManager.Projects[i].ProjectJournal.Events.Count; j++)
				{
					BoldDates(_projectManager.Projects[i].ProjectJournal.Events[j].StartDate, _projectManager.Projects[i].ProjectJournal.Events[j].EndDate);
				}
			}
			
			monthCalendar.BoldedDates = _boldedDates.ToArray();
		}

		private void BoldDates(DateTime startDateTime, DateTime endDateTime)
		{
			if (!_boldedDates.Contains(startDateTime))
				_boldedDates.Add(startDateTime);

			if (!_boldedDates.Contains(endDateTime))
				_boldedDates.Add(endDateTime);
		}

		private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
		{
			List<ProjectEvent> tempList = new List<ProjectEvent>();
			_events = new BindingList<ProjectEvent>();
			DateTime selectedDate = monthCalendar.SelectionRange.Start;
			eventListLbl.Text = "Händelser " + selectedDate.ToShortDateString();

			for (int i = 0; i < _projectManager.Projects.Count; i++)
			{
				for (int j = 0; j < _projectManager.Projects[i].ProjectJournal.Events.Count; j++)
				{
					if (_projectManager.Projects[i].ProjectJournal.Events[j].StartDate.ToShortDateString() == selectedDate.ToShortDateString())
					{
						_events.Add(_projectManager.Projects[i].ProjectJournal.Events[j]);
					}
				}
			}

			eventListBox.DataSource = tempList;
			eventListBox.DataSource = null;
			eventListBox.DataSource = _events;
			eventListBox.DisplayMember = "Name";
		}

		private void eventListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedEvent = (ProjectEvent)eventListBox.SelectedItem;
			LoadSelectedEvent();
			_isNewEvent = false;
		}

		private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
			{
			showStartDateLbl.Text = startDateTimePicker.Value.ToLongDateString();
			}

		private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
			{
			showEndDateLbl.Text = endDateTimePicker.Value.ToLongDateString();
			}

		private void eventAddNoteBtn_Click(object sender, EventArgs e)
		{
			Note newNote = new Note();
			newNote.Text = eventAddNoteBox.Text;
			newNote.NoteDate = DateTime.Now;
			_selectedEvent.Notes.Add(newNote);
			eventAddNoteBox.Clear();
		}

		private void meetingRemoveParticipantBtn_Click(object sender, EventArgs e)
		{
			_selectedEvent.Participants.Remove((Person)meetingParticipantBox.SelectedItem);
		}

		private void meetingAddParticipantBtn_Click(object sender, EventArgs e)
		{
			Person selectedParticipantToAdd = (Person)meetingAddParticipantBox.SelectedItem;
			if (_selectedEvent.Participants.SingleOrDefault(p => p.Equals(selectedParticipantToAdd)) == null)
				_selectedEvent.Participants.Add(selectedParticipantToAdd);
		}

		private void eventCompanyBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedCompany = (Company)eventCompanyBox.SelectedItem;
            if (_selectedCompany != null)
            {
                eventProjectBox.DataSource = _selectedCompany.Projects;
                eventProjectBox.DisplayMember = "Name";
            }
            
		}

		private void eventProjectBox_SelectedValueChanged(object sender, EventArgs e)
		{
			_selectedProject = (Project)eventProjectBox.SelectedItem;
			meetingAddParticipantBox.DataSource = _selectedProject.Roles;
			meetingAddParticipantBox.DisplayMember = "Person";
		}

		private void createEventBtn_Click(object sender, EventArgs e)
		{
			_isNewEvent = true;
			_selectedEvent = new ProjectEvent();
			this.Text = "Ny händelse";

			eventCompanyBox.Enabled = true;
			eventProjectBox.Enabled = true;
			startDateTimePicker.Enabled = true;
			endDateTimePicker.Enabled = true;

			eventNameBox.Text = "Titel";
			eventCompanyBox.DataSource = _companyManager.Companies;
			eventCompanyBox.DisplayMember = "Name";

			startDateTimePicker.Value = DateTime.Now;
			endDateTimePicker.Value = DateTime.Now;
			eventNoteBox.DataSource = _selectedEvent.Notes;
			eventNoteBox.DisplayMember = "Name";

			meetingStreetBox.Text = _selectedEvent.Location.Street;
			meetingZipBox.Text = _selectedEvent.Location.ZipCode;
			meetingCityBox.Text = _selectedEvent.Location.City;
			meetingParticipantBox.DataSource = null;
			meetingParticipantBox.DataSource = _selectedEvent.Participants;
			meetingParticipantBox.DisplayMember = "Person";
			meetingAddParticipantBox.DataSource = null;
		}

		private void eventSaveBtn_Click(object sender, EventArgs e)
		{
			if (_isNewEvent)
		{
				eventCompanyBox.Enabled = false;
				eventProjectBox.Enabled = false;
				startDatetimeLbl.Enabled = false;
				endDateTimePicker.Enabled = false;
				_selectedEvent.StartDate = startDateTimePicker.Value;
				_selectedEvent.EndDate = endDateTimePicker.Value;
				_projectManager.Projects.SingleOrDefault(p => p.Equals(eventProjectBox.SelectedItem)).ProjectJournal.Events.Add(_selectedEvent);

				BoldDates(_selectedEvent.StartDate, _selectedEvent.EndDate);
				monthCalendar.BoldedDates = _boldedDates.ToArray();
		}

			_selectedEvent.Name = eventNameBox.Text;
			_selectedEvent.Location.Street = meetingStreetBox.Text;
			_selectedEvent.Location.ZipCode = meetingZipBox.Text;
			_selectedEvent.Location.City = meetingCityBox.Text;

			this.Text = _selectedEvent.Name;

            SaveDataXml.SaveProjects(_projectManager.Projects);
		}

		private void eventNoteBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Note selectedNote = (Note)eventNoteBox.SelectedItem;
			NoteForm noteForm = new NoteForm(selectedNote);
			noteForm.ShowDialog();
		}

		private void eventGoToCompany_Click(object sender, EventArgs e)
		{
			tabControl.SelectedIndex = 3;
			LoadSelectedCompany();
		}

		private void eventGoToProjectBtn_Click(object sender, EventArgs e)
		{
			tabControl.SelectedIndex = 1;
			LoadSelectedProject();
		}
		#endregion

		#region "Contacts"
		private void ContactTabSetup()
		{
			contactChoiceBox.SetHeader("Dina kontakter");
			contactChoiceBox.SetData(_personManager.Persons, "Name");
			contactChoiceBox.SetButtonTexts("Ny kontakt");

			contactProjectBox.SetHeader("Projekt");
			contactProjectBox.SetButtonTexts("Nytt projekt");

			contactRelationBox.SetHeader("Närstående");
			contactRelationBox.SetButtonTexts("Lägg till");
		}
		// Contact Container: Panel 1
		private void contactChoiceBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedPerson = (Person)e.ChosenItem;
			if (_selectedPerson != null)
			{
				LoadSelectedPerson();
			}
		}
		private void contactChoiceBox_OnAdd()
		{
			CreatePersonForm createPersonForm = new CreatePersonForm(_personManager, _companyManager);
			createPersonForm.ShowDialog();
			contactChoiceBox.SetData(_personManager.Persons, "Person");
		}

		// Contact Container: Panel 2
		private void contactControl_OnSavePersonChanges()
		{
			this.Text = _selectedPerson.ToString();
			contactChoiceBox.SetData(_personManager.Persons, "Person");
		}
		private void contactControl_OnDoubleClickNote(object sender, DoubleClickNoteHandlerEventArgs e)
		{
			NoteForm noteForm = new NoteForm(e.SelectedNote);
			noteForm.ShowDialog();
		}

		private void contactProjectBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedProject = (Project)e.ChosenItem;
		}
		private void contactProjectBox_OnDoubleClickChoice(object sender, DoubleClickHandlerEventArgs e)
		{
			tabControl.SelectedIndex = 1;
			LoadSelectedProject();
		}
		private void contactProjectBox_OnAdd()
		{
			CreateProjectForm createProjectform = new CreateProjectForm(_selectedPerson, _projectManager, _personManager, _companyManager);
			createProjectform.ShowDialog();
			RefreshChoiceBox(contactProjectBox, _projectManager.Projects.Where(p => p.Roles.Any(r => r.Id == _selectedPerson.Id)).ToList(), "Name");
		}

		private void contactRelationBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedPerson = (Person)e.ChosenItem;
		}
		private void contactRelationBox_OnDoubleClickChoice(object sender, DoubleClickHandlerEventArgs e)
		{
			tabControl.SelectedIndex = 2;
			LoadSelectedPerson();
		}
		private void contactRelationBox_OnAdd()
		{
			CreatePersonForm createRelationForm = new CreatePersonForm(true, _selectedPerson, _personManager);
			createRelationForm.ShowDialog();
			RefreshChoiceBox(contactRelationBox, _selectedPerson.Relations, "Person");
		}

		#endregion

		#region "Company"
		private void CompanyTabSetup()
		{
			companyChoiceBox.SetHeader("Dina kundföretag");
			companyChoiceBox.SetData(_companyManager.Companies, "Name");
			companyChoiceBox.SetButtonTexts("Nytt företag");

			companyProjectBox.SetHeader("Projekt");
			companyProjectBox.SetButtonTexts("Skapa");

			companyEmployeeBox.SetHeader("Kontakter");
			companyEmployeeBox.SetButtonTexts("Skapa");
		}
		// Company Container: Panel 1
		private void companyChoiceBox_OnAdd()
		{
			CreateCompanyForm createCompanyForm = new CreateCompanyForm(_companyManager);
			createCompanyForm.ShowDialog();
			companyChoiceBox.SetData(_companyManager.Companies, "Name");
		}
		private void companyChoiceBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedCompany = (Company)e.ChosenItem;
			if (_selectedCompany != null)
			{
				LoadSelectedCompany();
			}
		}

		// Company Container: Panel 2
		private void companyControl_OnSaveCompanyChanges()
		{
			this.Text = _selectedCompany.Name;
			companyChoiceBox.SetData(_companyManager.Companies, "Name");
		}

		private void companyProjectBox_OnAdd()
		{
			CreateProjectForm createProjectForm = new CreateProjectForm(_selectedCompany, _projectManager, _personManager, _companyManager);
			createProjectForm.ShowDialog();
			RefreshChoiceBox(companyProjectBox, _selectedCompany.Projects, "Name");
		}
		private void companyProjectBox_OnDoubleClick(object sender, DoubleClickHandlerEventArgs e)
		{
			tabControl.SelectedIndex = 1;
			LoadSelectedProject();
		}
		private void companyProjectBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedProject = (Project)e.ChosenItem;
		}

		private void companyEmployeeBox_OnDoubleClick(object sender, DoubleClickHandlerEventArgs e)
		{
			tabControl.SelectedIndex = 2;
			LoadSelectedPerson();
		}
		private void companyEmployeeBox_OnAdd()
		{
			CreatePersonForm createPersonForm = new CreatePersonForm(_selectedCompany, _personManager, _companyManager);
			createPersonForm.ShowDialog();
			RefreshChoiceBox(companyEmployeeBox, _selectedCompany.Employees, "Person");
		}
		private void companyEmployeeBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedPerson = (Person)e.ChosenItem;
		}
		#endregion

		#region "Project"
		private void ProjectTabSetup()
		{
			projectChoiceBox.SetHeader("Dina projekt");
			projectChoiceBox.SetData(_projectManager.Projects, "Name");
			projectChoiceBox.SetButtonTexts("Nytt projekt");

			projectParticipantBox.SetHeader("Deltagare");
			projectParticipantBox.SetButtonTexts("Ta bort");

			projectAvailableParticipantsBox.SetHeader("Valbara kontakter");
			projectAvailableParticipantsBox.SetButtonTexts("Lägg till");

			projectEventBox.SetHeader("Händelser");
			projectEventBox.SetButtonTexts("Lägg till");

			projectNoteBox.SetHeader("Anteckningar");
			projectNoteBox.SetButtonTexts("Lägg till");
		}
		// Project Container: Panel 1
		private void projectChoiceBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedProject = (Project)e.ChosenItem;
			if (_selectedProject != null)
			{
				LoadSelectedProject();
			}
		}
		private void projectChoiceBox_OnAdd()
		{
			CreateProjectForm createProjectForm = new CreateProjectForm(_projectManager, _personManager, _companyManager);
			createProjectForm.Show();
			projectChoiceBox.SetData(_projectManager.Projects, "Name");
		}
		private void saveBtn_Click(object sender, EventArgs e)
		{
			_selectedProject.Name = projectNameBox.Text;
			_selectedProject.Description = projectDescBox.Text;
			projectChoiceBox.SetData(_projectManager.Projects, "Name");
            SaveDataXml.SaveAll(_companyManager.Companies, _personManager.Persons, _projectManager.Projects);
		}

		// Project Container: Panel 2
		private void projectParticipantBox_OnRemove()
		{
			_selectedProject.Roles.Remove((Person)projectParticipantBox.GetSelectedItem());
			RefreshChoiceBox(projectParticipantBox, _selectedProject.Roles, "Person");
		}
		private void projectParticipantBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedPerson = (Person)e.ChosenItem;
		}
		private void projectParticipantBox_OnDoubleClickChoice(object sender, DoubleClickHandlerEventArgs e)
		{
			tabControl.SelectedIndex = 2;
			LoadSelectedPerson();
		}

		private void projectAvailableParticipantsBox_OnAdd()
		{
			Person selectedParticipantToAdd = (Person)projectAvailableParticipantsBox.GetSelectedItem();
			if (_selectedProject.Roles.SingleOrDefault(r => r.Id == selectedParticipantToAdd.Id) == null)
			{
				_selectedProject.Roles.Add((Person)projectAvailableParticipantsBox.GetSelectedItem());
				RefreshChoiceBox(projectParticipantBox, _selectedProject.Roles, "Person");
			}
		}

		private void projectNoteBox_OnAdd()
		{
			CreateNoteForm createNoteForm = new CreateNoteForm(_selectedProject.Notes);
			createNoteForm.ShowDialog();
			RefreshChoiceBox(projectNoteBox, _selectedProject.Notes, "Note");
		}
		private void projectNoteBox_OnDoubleClickChoice(object sender, DoubleClickHandlerEventArgs e)
		{
			Note noteToEdit = (Note)projectNoteBox.listBox.SelectedItem;
			CreateNoteForm createNoteForm = new CreateNoteForm(noteToEdit);
			createNoteForm.ShowDialog();
			RefreshChoiceBox(projectNoteBox, _selectedProject.Notes, "Note");
		}
		private void projectEventBox_OnAdd()
		{
			CreateEventForm createEventForm = new CreateEventForm(_selectedProject);
			createEventForm.ShowDialog();
			RefreshChoiceBox(projectEventBox, _selectedProject.ProjectJournal.Events, "ProjectEvent");
		}
		private void projectEventBox_OnDoubleClickChoice(object sender, DoubleClickHandlerEventArgs e)
		{
            if (projectEventBox.listBox.SelectedItem != null)
            {
            _selectedEvent = (ProjectEvent)projectEventBox.listBox.SelectedItem;
            tabControl.SelectedIndex = 0;
            LoadSelectedEvent();
		}
		}
		private void projectEventBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedEvent = (ProjectEvent)projectEventBox.GetSelectedItem();
		}

		#endregion


		public static void RefreshChoiceBox(ChoiceBox choiceBox, object dataSource, string displayMember)
		{
			choiceBox.SetData(dataSource, displayMember);
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Text = tabControl.SelectedTab.Text;
		}
		private void LoadSelectedProject()
		{
			this.Text = _selectedProject.Name;
			projectNameBox.Text = _selectedProject.Name;
			projectIdBox.Text = _selectedProject.Id.ToString();
			projectCompanyBox.Text = _companyManager.Companies.SingleOrDefault(c => c.Projects.Any(p => p.Id == _selectedProject.Id)).Name;
			projectDescBox.Text = _selectedProject.Description;

			projectParticipantBox.SetData(_selectedProject.Roles, "Person");
			projectAvailableParticipantsBox.SetData(_companyManager.Companies.SingleOrDefault(c => c.Projects.Any(p => p.Id == _selectedProject.Id)).Employees, "Person");
			projectEventBox.SetData(_selectedProject.ProjectJournal.Events, "ProjectEvent");
			projectNoteBox.SetData(_selectedProject.ProjectJournal.Notes, "Note");
			RefreshChoiceBox(projectNoteBox, _selectedProject.Notes, "Note");
		}
		private void LoadSelectedPerson()
		{
			List<Project> projects = _projectManager.Projects.Where(p => p.Roles.Any(r => r.Id == _selectedPerson.Id)).ToList();

			this.Text = _selectedPerson.ToString();
			contactControl.SetPersonInfo(_selectedPerson, _companyManager, _projectManager);
			contactProjectBox.SetData(projects, "Name");
			contactRelationBox.SetData(_selectedPerson.Relations, "Person");
		}
		private void LoadSelectedCompany()
		{
			this.Text = _selectedCompany.Name;
			companyControl.SetCompanyInfo(_selectedCompany);
			companyProjectBox.SetData(_selectedCompany.Projects, "Name");
			companyEmployeeBox.SetData(_selectedCompany.Employees, "Person");
		}
		private void LoadSelectedEvent()
		{
			_selectedProject = _projectManager.Projects.SingleOrDefault(p => p.ProjectJournal.Events.Any(pEvent => pEvent.Equals(_selectedEvent)));
			_selectedCompany = _companyManager.Companies.SingleOrDefault(c => c.Projects.Any(p => p.Equals(_selectedProject)));

			eventNameBox.Text = _selectedEvent.Name;
			eventCompanyBox.DataSource = _companyManager.Companies;
			eventCompanyBox.DisplayMember = "Name";
			eventCompanyBox.SelectedItem = _selectedCompany;
			eventProjectBox.DataSource = _projectManager.Projects;
			eventProjectBox.DisplayMember = "Name";
			eventProjectBox.SelectedItem = _selectedProject;

			startDateTimePicker.Value = _selectedEvent.StartDate;
			endDateTimePicker.Value = _selectedEvent.EndDate;
			eventNoteBox.DataSource = _selectedEvent.Notes;
			eventNoteBox.DisplayMember = "Name";

			meetingStreetBox.Text = _selectedEvent.Location.Street;
			meetingZipBox.Text = _selectedEvent.Location.ZipCode;
			meetingCityBox.Text = _selectedEvent.Location.City;
			meetingParticipantBox.DataSource = null;
			meetingParticipantBox.DataSource = _selectedEvent.Participants;
			meetingParticipantBox.DisplayMember = "Person";
			meetingAddParticipantBox.DataSource = null;
			meetingAddParticipantBox.DataSource = _selectedProject.Roles;
			meetingAddParticipantBox.DisplayMember = "Person";
		}
		private void quitBtn_Click(object sender, EventArgs e)
		{
            SaveDataXml.SaveAll(_companyManager.Companies, _personManager.Persons, _projectManager.Projects);
            //SaveDataXml.SaveCompanies(_companyManager.Companies);
            //SaveDataXml.SavePersons(_personManager.Persons);
            //SaveDataXml.SaveProjects(_projectManager.Projects);
			Application.Exit();
		}

	}
}
