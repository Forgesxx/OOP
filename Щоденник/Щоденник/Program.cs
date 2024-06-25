using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Щоденник
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            MainForm diaryForm = new MainForm();

        

        Application.Run(diaryForm);
            Application.EnableVisualStyles();
        }
    }
}
