using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerkleyUpdateCreator.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btn_editTypes_Click(object sender, EventArgs e)
        {
            var meetingTypesForm = new MeetingTypesForm();
            meetingTypesForm.typeTimeMappingsDict = SessionStorage.typeTimeMappings;
            var result = meetingTypesForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                SessionStorage.typeTimeMappings = meetingTypesForm.typeTimeMappingsDict;
            }
        }

        private void cbx_jiraTicketTitle_CheckedChanged(object sender, EventArgs e)
        {
            SessionStorage.JiraCheckedDefault = cbx_jiraTicketTitle.Checked;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            cbx_jiraTicketTitle.Checked = SessionStorage.JiraCheckedDefault;
        }
    }
}
