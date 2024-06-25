using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Щоденник
{
    public static class NotesFilter
    {
        public static bool FilterByStringProperty(Note note, Func<Note, string> getStringProperty, string filterValue)
        {
            string propertyValue = getStringProperty(note);
            return propertyValue.Contains(filterValue);
        }

        public static bool FilterByNoteNumber(Note note, int noteNumber)
        {
            if (note.GetNoteNumber().ToString().Contains(noteNumber.ToString()))
            {
                return true;
            }

            return false;
        }

        public static bool FutureEvents(Note note)
        {
            if (note.GetDate() < DateTime.Now)
            {
                return false;
            }

            return true;
        }

        public static bool PastEvents(Note note)
        {
            if (note.GetDate() > DateTime.Now)
            {
                return false;
            }

            return true;
        }

        public static bool TodayEvents(Note note)
        {
            if (note.GetDate() != DateTime.Now.Date)
            {
                return false;
            }

            return true;
        }

        public static bool SpecificDate(Note note, DateTime date)
        {
            if (note.GetDate() != date.Date)
            {
                return false;
            }

            return true;
        }

        public static bool FilterByDuration(Note note, TimeSpan duration)
        {
            if (note.GetDuration() != duration)
            {
                return false;
            }

            return true;
        }  
        
        public static bool FilterByTime(Note note, TimeSpan time)
        {
            if (note.GetTime() <= time && note.GetTime() + note.GetDuration() >= time)
            {
                return true;
            }

            return false;
        }
    }
}
