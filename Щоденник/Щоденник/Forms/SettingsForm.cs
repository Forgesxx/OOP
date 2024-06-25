using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Щоденник.Forms
{
    public partial class SettingsForm : Form
    {
        public bool reminderSettingOn;

        public int numberOfNotesToRemind;

        public bool automaticOpeningLastFileSetting;

        public SettingsForm(bool reminderOn, int numberOfNotesToRemind, bool automaticOpeningLastFile)
        {
            InitializeComponent();
            reminderSettingOn = reminderOn;
            reminderOnButton.CheckedChanged += reminder_CheckedChanged;
            reminderOffButton.CheckedChanged += reminder_CheckedChanged;
            automaticOpeningLastFileOn.CheckedChanged += automaticOpeningLastFile_CheckedChanged;
            automaticOpeningLastFileOff.CheckedChanged += automaticOpeningLastFile_CheckedChanged;
            reminderOnButton.Checked = reminderOn;
            reminderOffButton.Checked = !reminderOn;
            this.numberOfNotesToRemind = numberOfNotesToRemind;
            numberOfNotesToRemindNumeric.Value = numberOfNotesToRemind;
            automaticOpeningLastFileSetting = automaticOpeningLastFile;
            automaticOpeningLastFileOn.Checked = automaticOpeningLastFile;
            automaticOpeningLastFileOff.Checked = !automaticOpeningLastFile;
        }

        private void reminder_CheckedChanged(object sender, EventArgs e)
        {
            reminderSettingOn = reminderOnButton.Checked;
        }

        private void numberOfNotesToRemind_CheckedChanged(object sender, EventArgs e)
        {
            reminderSettingOn = reminderOnButton.Checked;
        }

        private void numberOfNotesToRemindNumeric_ValueChanged(object sender, EventArgs e)
        {
            numberOfNotesToRemind = Convert.ToInt32(numberOfNotesToRemindNumeric.Value);
        }

        private void automaticOpeningLastFile_CheckedChanged(object sender, EventArgs e)
        {
            automaticOpeningLastFileSetting = automaticOpeningLastFileOn.Checked;
        }
    }
}
