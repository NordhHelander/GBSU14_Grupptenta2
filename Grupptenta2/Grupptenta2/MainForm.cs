using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestClasses;
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
		private static Meeting _selectedMeeting;
		private static List<DateTime> _boldedDates;
		private static BindingList<ProjectEvent> _events = new BindingList<ProjectEvent>();

		public MainForm()
		{
			_personManager = new PersonManager();
			_companyManager = new CompanyManager();
			_projectManager = new ProjectManager();

			InitializeComponent();

			CreateMocks();
			//SaveDataXml.SaveCompanies(_companyManager.Companies);
			//SaveDataXml.SavePersons(_personManager.Persons);
			//SaveDataXml.SaveProjects(_projectManager.Projects);

			SetEventMethods();
			CalendarBoldDates();
			ProjectTabSetup();
			ContactTabSetup();
			CompanyTabSetup();
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
			Meeting newMeeting = new Meeting();
			newMeeting.StartDate = new DateTime(2014, 11, 25, 14, 00, 00);
			newMeeting.EndDate = new DateTime(2014, 11, 25, 15, 30, 00);
			newMeeting.Name = "Testhändelse 1";
			newMeeting.Notes.Add(newNote1);
			newMeeting.Participants.Add(_personManager.Persons[0]);
			newMeeting.Participants.Add(_personManager.Persons[1]);
			_companyManager.Companies[0].Projects[0].ProjectJournal.Events.Add(newMeeting);

			Note newNote2 = new Note();
			newNote2.NoteDate = DateTime.Now.AddDays(-2);
			newNote2.Text = "Presentationsmöte";
			ProjectEvent newProjectEvent = new ProjectEvent();
			newProjectEvent.StartDate = new DateTime(2014, 11, 10, 11, 30, 00);
			newProjectEvent.EndDate = new DateTime(2014, 11, 10, 13, 30, 00);
			newProjectEvent.Name = "Testhändelse 2";
			newProjectEvent.Notes.Add(newNote2);
			_companyManager.Companies[0].Projects[1].ProjectJournal.Events.Add(newProjectEvent);
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
			BindingList<ProjectEvent> tempEventList = new BindingList<ProjectEvent>();
			DateTime selectedDate = monthCalendar.SelectionRange.Start;
			eventListLbl.Text = "Händelser " + selectedDate.ToShortDateString();

			for (int i = 0; i < _projectManager.Projects.Count; i++)
			{
				for (int j = 0; j < _projectManager.Projects[i].ProjectJournal.Events.Count; j++)
				{
					if (_projectManager.Projects[i].ProjectJournal.Events[j].StartDate.ToShortDateString() == selectedDate.ToShortDateString())
					{
						tempEventList.Add(_projectManager.Projects[i].ProjectJournal.Events[j]);
					}
				}
			}

			_events = tempEventList;

			eventListBox.DataSource = null;
			eventListBox.DataSource = _events;
			eventListBox.DisplayMember = "Name";
		}

		private void eventListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Project eventProject = _projectManager.Projects.SingleOrDefault(p => p.ProjectJournal.Events.Any(pEvent => pEvent.Equals(_selectedEvent)));
			Company eventCompany = _companyManager.Companies.SingleOrDefault(c => c.Projects.Any(p => p.Equals(eventProject)));

			if (eventListBox.SelectedItem is Meeting)
			{
				_selectedEvent = (Meeting)eventListBox.SelectedItem;
				eventIsMeetingCheckBox.Checked = true;
				LoadEventInfo(eventCompany, eventProject);
				LoadMeetingInfo(eventProject);
			}
			else if (eventListBox.SelectedItem is ProjectEvent)
			{
				_selectedEvent = (ProjectEvent)eventListBox.SelectedItem;
				eventIsMeetingCheckBox.Checked = false;
				LoadEventInfo(eventCompany, eventProject);
			}
		}

		private void LoadMeetingInfo(Project eventProject)
		{
			_selectedMeeting = (Meeting)_selectedEvent;

			EnableMeetingInfo();

			meetingStreetBox.Text = _selectedMeeting.Location.Street;
			meetingZipBox.Text = _selectedMeeting.Location.ZipCode;
			meetingCityBox.Text = _selectedMeeting.Location.City;
			meetingParticipantBox.DataSource = null;
			meetingParticipantBox.DataSource = _selectedMeeting.Participants;
			meetingParticipantBox.DisplayMember = "Person";
			meetingAddParticipantBox.DataSource = null;
			meetingAddParticipantBox.DataSource = eventProject.Roles;
			meetingAddParticipantBox.DisplayMember = "Person";
		}

		private void LoadEventInfo(Company eventCompany, Project eventProject)
		{
			DisableMeetingInfo();

			eventNameBox.Text = _selectedEvent.Name;
			eventProjectBox.Text = eventProject.Name;
			eventCompanyBox.Text = eventCompany.Name;
			startDateTimePicker.Value = _selectedEvent.StartDate;
			showStartDateLbl.Text = _selectedEvent.StartDate.ToLongDateString();
			endDateTimePicker.Value = _selectedEvent.EndDate;
			showEndDateLbl.Text = _selectedEvent.EndDate.ToLongDateString();
			eventNoteBox.DataSource = _selectedEvent.Notes;
			eventNoteBox.DisplayMember = "Name";
		}

		private void EnableMeetingInfo()
		{
			meetingStreetBox.Enabled = true;
			meetingZipBox.Enabled = true;
			meetingCityBox.Enabled = true;
			meetingParticipantBox.Enabled = true;
			meetingAddParticipantBox.Enabled = true;
			meetingAddParticipantBtn.Enabled = true;
			meetingRemoveParticipantBtn.Enabled = true;

		}
		private void DisableMeetingInfo()
		{
			meetingStreetBox.Enabled = false;
			meetingZipBox.Enabled = false;
			meetingCityBox.Enabled = false;
			meetingParticipantBox.Enabled = false;
			meetingAddParticipantBox.Enabled = false;
			meetingAddParticipantBtn.Enabled = false;
			meetingRemoveParticipantBtn.Enabled = false;
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
			_selectedMeeting.Participants.Remove((Person)meetingParticipantBox.SelectedItem);
		}

		private void meetingAddParticipantBtn_Click(object sender, EventArgs e)
		{
			Person selectedParticipantToAdd = (Person)meetingAddParticipantBox.SelectedItem;
			if (_selectedMeeting.Participants.SingleOrDefault(p => p.Equals(selectedParticipantToAdd)) == null)
				_selectedMeeting.Participants.Add(selectedParticipantToAdd);
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
		}

		// Contact Container: Panel 2
		private void contactControl_OnSavePersonChanges()
		{
			this.Text = _selectedPerson.ToString();
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
			RefreshChoiceBox(projectChoiceBox, _projectManager.Projects, "Name");
		}
		private void saveBtn_Click(object sender, EventArgs e)
		{
			_selectedProject.Name = projectNameBox.Text;
			_selectedProject.Description = projectDescBox.Text;
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
			throw new NotImplementedException();
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

		private void quitBtn_Click(object sender, EventArgs e)
		{
			SaveDataXml.SaveCompanies(_companyManager.Companies);
			SaveDataXml.SavePersons(_personManager.Persons);
			SaveDataXml.SaveProjects(_projectManager.Projects);
			Application.Exit();
		}
	}
}
