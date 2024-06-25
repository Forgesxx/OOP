using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Щоденник
{
    public class NoteComparer : IComparer<Note>
    {
        public enum SortType
        {
            dateAndTime,
            title,
            duration,
            noteNumber
        }

        private SortType sortType;

        private bool sortByGrowth;


        public NoteComparer(SortType sortType, bool sortByGrowth)
        {
            this.sortType = sortType;

            this.sortByGrowth = sortByGrowth;
        }
        public int Compare(Note x, Note y)
        {
            int result;
            if (sortType == SortType.dateAndTime)
            {
                result = DateTime.Compare(x.GetDateTime(), y.GetDateTime());

                return sortByGrowth ? result : -result;
            }
            else if (sortType == SortType.title)
            {

                result = string.Compare(x.GetTitle(), y.GetTitle());

                return sortByGrowth ? result : -result;
                

            }
            else if (sortType == SortType.duration)
            {
                result = TimeSpan.Compare(x.GetDuration(), y.GetDuration());

                return sortByGrowth ? result : -result;
            }
            else if (sortType == SortType.noteNumber)
            {
                result = x.GetNoteNumber() - y.GetNoteNumber();

                return sortByGrowth ? result : -result;
            }
            else
            {
                throw new ArgumentException();
            }

        }
    }
}
