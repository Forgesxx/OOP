using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Щоденник.Models
{
    public static class SaveAndLoadNotes
    {
        private static string saveNote(Note note)
        {
            string result = "";

            if (note != null)
            {
                result += note.GetNoteNumber() + "\n";
                result += note.GetTitle() + "\n";
                result += note.GetDate().ToString("d") + "\n";
                result += note.GetTime() + "\n";
                result += note.GetDuration().ToString("t") + "\n";
                result += note.GetVenue() + "\n";
                result += note.GetDescription();
            }

            return result;
        }

        public static void SaveNotes(List<Note> notes, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < notes.Count; i++)
                {
                    writer.WriteLine(saveNote(notes[i]));
                }
            }
        }

        public static void LoadNotes(List<Note> notes, string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    int noteNumber;
                    string title;
                    DateTime date;
                    TimeSpan time;
                    TimeSpan duration;
                    string venue;
                    string description;
                    while ((noteNumber = Convert.ToInt32(reader.ReadLine())) != 0)
                    {
                        title = reader.ReadLine();
                        date = Convert.ToDateTime(reader.ReadLine());
                        time = TimeSpan.Parse(reader.ReadLine());
                        duration = TimeSpan.Parse(reader.ReadLine());
                        venue = reader.ReadLine();
                        description = reader.ReadLine();
                        notes.Add(new Note(noteNumber, title, date + time, duration, venue, description)); ;
                    }
                }
            }
            catch
            {
                throw new ArgumentException();
            }
        }
    }

    

    


}
