using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Щоденник.Controls;
using Щоденник.Forms;
using System.Reflection;

namespace Щоденник 
{
    public partial class MainForm : Form
    {
        private Diary diary = new Diary();

        private List<Note> filterNotes;

        private DataTable table;

        public bool changes;

        List<List<Note>> overlaysNotes;

        List<List<Note>> filterOverlaysNotes;

        public bool overlaysNotesOn = false;

        public bool filterOn = false;

        private const string settingPath = "Settings\\Settings.txt";

        private int numberOfNotesToRemind;

        private string filePath;

        private bool reminderOn;

        private bool automaticOpeningLastFile;

        public MainForm()
        {
            InitializeComponent();

            loadSettings();

            filterNotes = diary.GetNotes();

            SetDataPropertyName(notesTable);

            table = new DataTable();

            table.Columns.Add("noteNumber", typeof(int));
            table.Columns.Add("title", typeof(string));
            table.Columns.Add("date", typeof(DateTime));
            table.Columns.Add("time", typeof(TimeSpan));
            table.Columns.Add("duration", typeof(TimeSpan));
            table.Columns.Add("venue", typeof(string));
            table.Columns.Add("description", typeof(string));

            if (filePath != null)
            {
                createDiary();
            }

            noteBindingSource.DataSource = table;

            noteNumberCheckBox.CheckedChanged += filterCheck;

            noteNumberNumeric.ValueChanged += filterCheck;

            nameBox.TextChanged += filterCheck;

            venueBox.TextChanged += filterCheck;

            descriptionBox.TextChanged += filterCheck;

            dateTimePicker.ValueChanged += filterCheck;

            timePicker.ValueChanged += filterCheck;

            durationPicker.ValueChanged += filterCheck;

            timeCheckBox.CheckedChanged += filterCheck;

            durationCheckBox.CheckedChanged += filterCheck;

            specificDateRadioButton.Click += filterCheck;

            pastEventsRadioButton.Click += filterCheck;

            futureEventsRadioButton.Click += filterCheck;

            todayEventsRadioButton.Click += filterCheck;

            allNotesRadioButton.Click += filterCheck;

            dateAndTimeSort.Click += sortTypeChange;

            titleSort.Click += sortTypeChange;

            durationSort.Click += sortTypeChange;

            noteNumberSort.Click += sortTypeChange;

            sortByGrowthRadioButton.Click += sortDirectionChange;

            sortByDescendingRadioButton.Click += sortDirectionChange;

            analysisOfOverlaysOn.Click += analysisOfOverlaysChange;

            analysisOfOverlaysOff.Click += analysisOfOverlaysChange;

            noteNumberNumeric.Maximum = decimal.MaxValue;

            notesTable.Columns[6].AutoSizeMode = notesTable.Columns[5].AutoSizeMode = notesTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void createDiary()
        {
            diary.LoadNotes(filePath);

            filterNotes.Sort(new NoteComparer(diary.CurrentSortType, diary.SortByGrowth));

            CreateTable();

            if (reminderOn)
            {
                ReminderFormTimerShow.Start();
            }
        }

        public void SetDataPropertyName(DataGridView notesTable)
        {
            notesTable.Columns["noteNumber"].DataPropertyName = "noteNumber";
            notesTable.Columns["title"].DataPropertyName = "title";
            notesTable.Columns["date"].DataPropertyName = "date";
            notesTable.Columns["time"].DataPropertyName = "time";
            notesTable.Columns["duration"].DataPropertyName = "duration";
            notesTable.Columns["venue"].DataPropertyName = "venue";
            notesTable.Columns["description"].DataPropertyName = "description";
        }

        private void loadSettings()
        {
            if (!File.Exists(settingPath) || new FileInfo(settingPath).Length == 0)
            {
                standartSettingsSet();
                return;
            }

            try
            {
                using (StreamReader reader = new StreamReader(settingPath))
                {

                    reminderOn = Convert.ToBoolean(reader.ReadLine());
                    numberOfNotesToRemind = Convert.ToInt32(reader.ReadLine());
                    string path = reader.ReadLine();
                    automaticOpeningLastFile = Convert.ToBoolean(reader.ReadLine());

                    if (path != "" && automaticOpeningLastFile)
                    {
                        filePath = path;
                    }
                }
            }
            catch
            {
                standartSettingsSet();
            }
            
        }

        private void standartSettingsSet()
        {
            using (StreamWriter writer = new StreamWriter(settingPath))
            {
                writer.WriteLine(true);
                writer.WriteLine(5);
                writer.WriteLine("");
                writer.WriteLine(true);

                reminderOn = true;
                numberOfNotesToRemind = 5;
                automaticOpeningLastFile = true;
            }
        }

        private void saveSettings()
        {
            string oldPath = "";
            using (StreamReader reader = new StreamReader(settingPath))
            {

                reader.ReadLine();
                reader.ReadLine();
                oldPath = reader.ReadLine();
            }

            using (StreamWriter writer = new StreamWriter(settingPath))
            {
                writer.WriteLine(reminderOn);
                writer.WriteLine(numberOfNotesToRemind);
                if (filePath != "")
                {
                    writer.WriteLine(filePath);
                } else
                {
                    writer.WriteLine(oldPath);
                }
                writer.WriteLine(automaticOpeningLastFile);
            }
        }

        public void checkChanges()
        {
            if (changes == false)
            {
                changes = true;
            }
        }

        public void CreateTable()
        {
            table.Clear();
            for (int i = 0; i < filterNotes.Count; i++)
            {
                DataRow newRow = AddNewRow(filterNotes[i]);
                table.Rows.Add(newRow);
            }
        }

        private DataRow AddNewRow(Note note)
        {
            DataRow newRow = table.NewRow();
            newRow["noteNumber"] = note.GetNoteNumber();
            newRow["title"] = note.GetTitle();
            newRow["date"] = note.GetDate();
            newRow["time"] = note.GetTime();
            newRow["duration"] = note.GetDuration();
            newRow["venue"] = note.GetVenue();
            newRow["description"] = note.GetDescription();
            return newRow;
        }
        
        private void filterCheck(object sender, EventArgs e)
        {
            if (noteNumberCheckBox.Checked || nameBox.Text != "" || descriptionBox.Text != "" || venueBox.Text != "" || !allNotesRadioButton.Checked || timeCheckBox.Checked || durationCheckBox.Checked)
            {
                filterOn = true;
                filterDiary();
            }
            else
            {
                filterOn = false;
                filterNotes = diary.GetNotes();
                filterOverlaysNotes = overlaysNotes;
                if (overlaysNotesOn)
                {
                    createOverlaysNotes();
                }
                else
                {
                    CreateTable();
                }
            }
        }

        private void filterDiary()
        {
            filterOverlaysNotes = new List<List<Note>>();
            filterNotes = new List<Note>();
            if (overlaysNotesOn)
            {
                foreach (List<Note> notes in overlaysNotes)
                {
                    foreach (Note note in notes)
                    {
                        if (!filterOn || CheckNote(note))
                        {
                            filterOverlaysNotes.Add(notes);
                            break;
                        }
                    }
                }
                createOverlaysNotes();
            }
            else
            {
                for (int i = 0; i < diary.Count; i++)
                {
                    if (!filterOn || CheckNote(diary[i]))
                    {
                        filterNotes.Add(diary[i]);
                    }
                }

                CreateTable();
            }
        }

        public bool CheckNote(Note note)
        {
                if (!NotesFilter.FilterByStringProperty(note, n => n.GetTitle(), nameBox.Text))
                {
                    return false;
                }

                if (!NotesFilter.FilterByStringProperty(note, n => n.GetVenue(), venueBox.Text))
                {
                    return false;
                }

                if (!NotesFilter.FilterByStringProperty(note, n => n.GetDescription(), descriptionBox.Text))
                {
                    return false;
                }

            if (noteNumberCheckBox.Checked && !NotesFilter.FilterByNoteNumber(note, Convert.ToInt16(noteNumberNumeric.Value)))
            {
                return false;
            }

            if (futureEventsRadioButton.Checked && !NotesFilter.FutureEvents(note))
                {
                    return false;
                }

                if (pastEventsRadioButton.Checked && !NotesFilter.PastEvents(note))
                {
                    return false;
                }

                if (todayEventsRadioButton.Checked && !NotesFilter.TodayEvents(note))
                {
                    return false;
                }

                if (specificDateRadioButton.Checked && !NotesFilter.SpecificDate(note, dateTimePicker.Value.Date))
                {
                    return false;
                }

                if (timeCheckBox.Checked && !NotesFilter.FilterByTime(note, timePicker.Value.TimeOfDay))
                {
                    return false;
                }

                if (durationCheckBox.Checked && !NotesFilter.FilterByDuration(note, durationPicker.Value.TimeOfDay))
                {
                    return false;
                } 

                return true;
            }

        private void sortRadioButtonsChange()
        {
            if (diary.CurrentSortType == NoteComparer.SortType.duration)
            {
                durationSort.Checked = true;
            }
            else if (diary.CurrentSortType == NoteComparer.SortType.dateAndTime)
            {
                dateAndTimeSort.Checked = true;
            }
            else if (diary.CurrentSortType == NoteComparer.SortType.title)
            {
                titleSort.Checked = true;
            }
            else if (diary.CurrentSortType == NoteComparer.SortType.noteNumber)
            {
                noteNumberSort.Checked = true;
            }
        }

        public void UpdateNote(Note note, int indexNote, DataTable table, NoteInteractionForm.TypeOfInteraction newNote)
        {
            checkChanges();

            if (!filterOn || CheckNote(note) == true)
            {
                DataRow newRow = AddNewRow(note);
                if (newNote == NoteInteractionForm.TypeOfInteraction.add)
                {
                    if (filterOn)
                    {
                        filterNotes.Add(note);
                        filterNotes.Sort(new NoteComparer(diary.CurrentSortType, diary.SortByGrowth));
                    }
                    
                    table.Rows.Add(newRow);

                    TableSort();
                }
                else
                {
                    table.Rows[indexNote].ItemArray = newRow.ItemArray;
                }
            } else if (newNote == NoteInteractionForm.TypeOfInteraction.edit)
            {
                table.Rows[indexNote].Delete();
            }
        }

        public void UpdateNoteNumbers(DataTable table, List<Note> filterNotes)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i][0] = filterNotes[i].GetNoteNumber();
            }
        }

        private void AddOrEdit_Click(object sender, EventArgs e)
        {
            NoteInteractionForm addForm = new NoteInteractionForm(diary, filterNotes, this, NoteInteractionForm.TypeOfInteraction.add, table);
            addForm.Text = "Додати запис";
            addForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int SearchIndexByNoteNumber(int noteNumber, List<Note> notes)
        {
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].GetNoteNumber() == noteNumber)
                {
                    return i;
                }
            }

            return -1;
        }

        private void notesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                InterectionWithNote(e.RowIndex, notesTable.Columns[e.ColumnIndex].Name);
            }
        }

        public bool InterectionWithNote(int index, string action)
        {
            if (action == "editButton")
            {
                editNote(index);
            }
            else if (action == "deleteButton")
            {
                if (!ConfirmNoteDeletion())
                {
                    return false; 
                }

                deleteNote(index);
            }
            else
            {
                viewNote(index);
            }

            return true;
        }

        private bool ConfirmNoteDeletion()
        {
            DialogResult result = MessageBox.Show("", "Ви впевнені, що хочете видалити замітку", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }

        private void editNote(int index)
        {
            if (overlaysNotesOn)
            {
                index = overlaysNotesIndexSearch(index);
            }

            NoteInteractionForm noteInteractionForm = new NoteInteractionForm(diary, overlaysNotesOn ? diary.GetNotes() : filterNotes, this, NoteInteractionForm.TypeOfInteraction.edit, table, index);
            noteInteractionForm.Text = "Редагувати запис";
            DialogResult dialogResult = noteInteractionForm.ShowDialog();

            if (dialogResult == DialogResult.OK && !overlaysNotesOn)
            {
                TableSort();
            }
        }

        private int overlaysNotesIndexSearch(int index)
        {
            List<Note> notes = createOverlaysNotesList();

            return SearchIndexByNoteNumber(notes[index].GetNoteNumber(), diary.GetNotes());
        }

        private List<Note> createOverlaysNotesList()
        {
            List<Note> notes = new List<Note>();

            foreach (List<Note> note in filterOverlaysNotes)
            {
                notes.AddRange(note);
            }

            return notes;
        }

        private void deleteNote(int index)
        {
            if (filterOn || overlaysNotesOn)
            {
                int indexInNotes = overlaysNotesOn ? overlaysNotesIndexSearch(index) : SearchIndexByNoteNumber(filterNotes[index].GetNoteNumber(), diary.GetNotes());

                diary.DeleteNote(indexInNotes);

                if (!overlaysNotesOn)
                {
                    filterNotes.RemoveAt(index);
                }
            }
            else
            {
                diary.DeleteNote(index);
            }

            if (overlaysNotesOn)
            {
                CreateOverlays();
            }
            else
            {
                table.Rows.RemoveAt(index);
                UpdateNoteNumbers(table, filterNotes);
            }
        }

        private void viewNote(int index)
        {
            if (overlaysNotesOn)
            {
                index = overlaysNotesIndexSearch(index);
            }
            NoteInteractionForm viewForm = new NoteInteractionForm(diary, overlaysNotesOn ? diary.GetNotes() : filterNotes, this, NoteInteractionForm.TypeOfInteraction.view, table, index);
            viewForm.Text = "Перегляд запису";
            viewForm.ShowDialog();
        }

        private void sortTypeChange(object sender, EventArgs e)
        {
            SortingTypeRadioButton clickedButton = sender as SortingTypeRadioButton;

            if (overlaysNotesOn == true)
            {
                if (clickedButton.SortType != NoteComparer.SortType.dateAndTime)
                {
                    MessageBox.Show("Аналіз накладок може сортуватися тільки за датою і часом");
                }
            } else
            {
                diary.CurrentSortType = clickedButton.SortType;

                if (filterOn)
                {
                    filterNotes.Sort(new NoteComparer(diary.CurrentSortType, diary.SortByGrowth));
                }

                TableSort();
            }
        }
        
        public void TableSort()
        {
            string sortDirection = diary.SortByGrowth ? "ASC" : "DESC";
            string sortType = Convert.ToString(diary.CurrentSortType);

            if (diary.CurrentSortType == NoteComparer.SortType.dateAndTime)
            {
                table.DefaultView.Sort = $"date {sortDirection}, time {sortDirection}";
            }
            else
            {
                table.DefaultView.Sort = $"{sortType} {sortDirection}";
            }

            table = table.DefaultView.ToTable();

            notesTable.DataSource = table;
        }


        private void sortDirectionChange(object sender, EventArgs e)
        {
            if (sortByGrowthRadioButton.Checked && !diary.SortByGrowth || !sortByGrowthRadioButton.Checked && diary.SortByGrowth)
            {
                diary.SortByGrowth = sortByGrowthRadioButton.Checked;

                if (overlaysNotesOn)
                {
                    overlaysNotes.Reverse();

                    if (filterOn)
                    {
                        filterOverlaysNotes.Reverse();
                    }

                    createOverlaysNotes();
                } else
                {
                    TableSort();
                }
            } 
        }

        private void DiaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
            {
                if (save() == DialogResult.Cancel && e != null)
                {
                    e.Cancel = true;
                    return;
                }
            }

            saveSettings();
        }

        private DialogResult save()
        {
            DialogResult result = MessageBox.Show("Зберегти зміни?", "", MessageBoxButtons.YesNoCancel);

            switch (result)
            {
                case DialogResult.Yes:
                    if (filePath != null)
                    {
                        diary.SaveData(filePath, diary.GetNotes());
                    }
                    else
                    {
                        saveAsToolStripMenuItem_Click(null, null);
                    }
                    return DialogResult.OK;
                case DialogResult.Cancel:
                    return DialogResult.Cancel;
                default: changes = false;
                    return DialogResult.No;
            }
        }

        private void analysisOfOverlaysChange(object sender, EventArgs e)
        {
            overlaysNotesOn = analysisOfOverlaysOn.Checked;

            if (overlaysNotesOn)
            {
                CreateOverlays();

                dateAndTimeSort.Checked = true;
            } else
            {
                sortRadioButtonsChange();

                filterCheck(null, null);

                CreateTable();
            }
        }

        private void createOverlaysNotes()
        {
            table.Clear();
            Color color = Color.White;
            int rowIndex = 0;
            foreach (List<Note> notes in filterOverlaysNotes)
            {
                if (color == Color.White)
                {
                    color = Color.LightGray;
                }
                else
                {
                    color = Color.White;
                }
                foreach (Note note in notes)
                {
                    DataRow newRow = AddNewRow(note);

                    table.Rows.Add(newRow);
                    notesTable.Rows[rowIndex++].DefaultCellStyle.BackColor = color;
                }
            }
        }

        public void CreateOverlays()
        {
            overlaysNotes = diary.AnalysisOfOverlaysSort();

            filterCheck(null, null);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changes)
            {
                DiaryForm_FormClosing(sender, null);
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                try
                {
                    returnToTheStandartPosition();

                    filterNotes = diary.GetNotes();

                    createDiary();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Відбулася помилка при зчитуванні текстового файлу");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                diary.SaveData(filePath, diary.GetNotes());
                changes = false;
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!changes || save() != DialogResult.Cancel) {

                filePath = null;
                changes = false;

                returnToTheStandartPosition();

                filterNotes = diary.GetNotes();
            }
        }

        private void returnToTheStandartPosition()
        {
            diary = new Diary();
            table.Clear();

            timeCheckBox.Checked = false;
            durationCheckBox.Checked = false;
            allNotesRadioButton.Checked = true;
            noteNumberCheckBox.Checked = false;
            nameBox.Text = "";
            venueBox.Text = "";
            descriptionBox.Text = "";
            analysisOfOverlaysOff.Checked = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(reminderOn, numberOfNotesToRemind, automaticOpeningLastFile);

            if (settings.ShowDialog() == DialogResult.OK)
            {
                reminderOn = settings.reminderSettingOn;

                numberOfNotesToRemind = settings.numberOfNotesToRemind;

                automaticOpeningLastFile = settings.automaticOpeningLastFileSetting;
            }
        }

        private void ReminderFormTimerShow_Tick(object sender, EventArgs e)
        {
            ReminderFormTimerShow.Stop();
            CreateReminderTable();
        }

        public void CreateReminderTable()
        {
            List<Note> reminderNotes = CreateReminder();

            DataTable reminderTable = table.Copy();
            reminderTable.Clear();

            int numberOfNotes = numberOfNotesToRemind > reminderNotes.Count ? reminderNotes.Count : numberOfNotesToRemind;

            for (int i = 0; i < numberOfNotes; i++)
            {
                DataRow row = reminderTable.NewRow();
                row.ItemArray = table.Rows[i].ItemArray;

                reminderTable.Rows.Add(row);
            }

            ReminderForm reminderForm = new ReminderForm(this, reminderTable, reminderNotes, diary.GetNotes());

            allNotesRadioButton.Checked = true;

            filterCheck(null, null);

            if (reminderNotes.Count == 0)
            {
                return;
            }

            reminderForm.ShowDialog();

        }

        public List<Note> CreateReminder()
        {
            NoteComparer.SortType sortTypeRemember = diary.CurrentSortType;

            futureEventsRadioButton.Checked = true;

            diary.CurrentSortType = NoteComparer.SortType.dateAndTime;

            filterCheck(null, null);

            List<Note> reminderNotes = filterNotes.Take(numberOfNotesToRemind).ToList();

            diary.CurrentSortType = sortTypeRemember;

            return reminderNotes;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddOrEdit_Click(sender, e);
            } else if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("", "Ви впевнені, що хочете вийти з щоденника?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void saveFileDialog(List<Note> notes)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                diary.SaveData(saveFileDialog.FileName, notes);
            }

            if (result != DialogResult.Cancel)
            {
                changes = false;
            }
        }

        private void saveFilteredNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (overlaysNotesOn)
            {
                saveFileDialog(createOverlaysNotesList());
            } else
            {
                saveFileDialog(filterNotes);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog(diary.GetNotes());
        }
    }
}
