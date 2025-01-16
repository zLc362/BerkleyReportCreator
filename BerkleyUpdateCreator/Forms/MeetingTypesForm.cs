using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerkleyUpdateCreator
{
    public partial class MeetingTypesForm : Form
    {
        public Dictionary<string, string> typeTimeMappingsDict { get; set; } = [];
        public MeetingTypesForm()
        {
            InitializeComponent();
        }
        private void updateItems()
        {
            typeTimeMappings.Items.Clear();
            typeTimeMappingsDict.Select(x => $"{x.Key} - {x.Value}").ToList().ForEach(el => typeTimeMappings.Items.Add(el));
        }

        private void btn_addDef_Click(object sender, EventArgs e)
        {
            var meetTime = meetingTimeInput.Text.Trim();
            var meetType = meetingTypeInput.Text.Trim();

            if (string.IsNullOrEmpty(meetType) || string.IsNullOrEmpty(meetTime)) { return; }

            if (!typeTimeMappingsDict.TryAdd(meetType, meetTime))
            {
                typeTimeMappingsDict.Remove(meetType);
                typeTimeMappingsDict.Add(meetType, meetTime);
            }

            updateItems();
        }

        private void btn_deleteDef_Click(object sender, EventArgs e)
        {
            var selectedIndex = typeTimeMappings.SelectedIndex;
            if (selectedIndex == -1) { return; }

            var selectedKey = typeTimeMappings?.SelectedItem?.ToString()?.Split(" - ")[0];

            if (selectedKey == null) return;

            typeTimeMappingsDict.Remove(selectedKey);

            updateItems();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MeetingTypesForm_Load(object sender, EventArgs e)
        {
            updateItems();
        }
    }
}
