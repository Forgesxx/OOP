using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Щоденник.Controls
{
    public class SortingTypeRadioButton : RadioButton
    {
        public NoteComparer.SortType SortType { get; set; }


    }
}
