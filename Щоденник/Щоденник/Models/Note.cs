using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Щоденник
{
    public class Note
    {
        private int noteNumber;
        private string title;
        private DateTime dateTime;
        private TimeSpan duration;
        private string venue;
        private string description;

        public int GetNoteNumber()
        {
            return noteNumber;
        }

        public void LowerNoteNumber()
        {
            noteNumber--;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetDescription()
        {
            return description;
        }

        public DateTime GetDate()
        {
            return dateTime.Date;
        }

        public TimeSpan GetTime()
        {
            return dateTime.TimeOfDay;
        }

        public DateTime GetDateTime()
        {
            return dateTime;
        }

        public TimeSpan GetDuration()
        {
            return duration;
        }

        public DateTime GetDateTimeDuration()
        {
            return dateTime + duration;
        }

        public string GetVenue()
        {
            return venue;
        }

        public Note(int noteNumber, string title, DateTime dateTime, TimeSpan duration, string venue, string description)
        {
            this.noteNumber = noteNumber;
            this.title = title;
            this.dateTime = dateTime;
            this.description = description;
            this.duration = duration;
            this.venue = venue;
        }

        public void EditNote(string newTitle, DateTime newDateTime, TimeSpan newDuration, string newVenue, string newDescription)
        {
            title = newTitle;
            description = newDescription;
            dateTime = newDateTime;
            duration = newDuration;
            venue = newVenue;
        }
    }
}
