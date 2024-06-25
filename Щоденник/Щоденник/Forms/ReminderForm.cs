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

namespace Щоденник
{
    public partial class ReminderForm : Form
    {
        private DataTable table;

        private MainForm mainForm;

        private List<Note> reminderNotes;

        private List<Note> notes;
        public ReminderForm(MainForm mainForm, DataTable table, List<Note> reminderNotes, List<Note> notes)
        {
            InitializeComponent();

            mainForm.SetDataPropertyName(reminderTable);

            noteBindingSource.DataSource = table;

            this.table = table;

            this.mainForm = mainForm;
            this.reminderNotes = reminderNotes;
            this.notes = notes;
        }

        private void reminderTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex > table.Rows.Count - 1)
            {
                return;
            }

            int index = mainForm.SearchIndexByNoteNumber(reminderNotes[e.RowIndex].GetNoteNumber(), notes);
            bool confirm = mainForm.InterectionWithNote(index, reminderTable.Columns[e.ColumnIndex].Name);
            if (confirm && reminderTable.Columns[e.ColumnIndex].Name == "deleteButton")
            {
                reminderNotes.RemoveAt(e.RowIndex);
                table.Rows.RemoveAt(e.RowIndex);
                mainForm.UpdateNoteNumbers(table, reminderNotes);
            }
            else if (reminderTable.Columns[e.ColumnIndex].Name == "editButton")
            {
                if (reminderNotes[e.RowIndex].GetDateTime() < DateTime.Now)
                {
                    reminderNotes.RemoveAt(e.RowIndex);
                    table.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    mainForm.UpdateNote(reminderNotes[e.RowIndex], e.RowIndex, table, NoteInteractionForm.TypeOfInteraction.edit);
                }
            } 
        }
    }
}
