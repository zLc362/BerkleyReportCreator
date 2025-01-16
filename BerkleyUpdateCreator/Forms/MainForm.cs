using BerkleyUpdateCreator.Forms;
using BerkleyUpdateCreator.Models;
using BerkleyUpdateCreator.Properties;
using System.Windows.Forms;

namespace BerkleyUpdateCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void UpdateMeetingTypes()
        {

            meetingType.Items.Clear();
            meetingType.Items.AddRange(SessionStorage.typeTimeMappings.Keys.ToArray());
            meetingType.SelectedIndex = 0;
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            SessionStorage.JiraCheckedDefault = Settings.Default.JiraTicketChecked;

            foreach (var mapping in Settings.Default.TypeTimeMappings)
            {
                var key = mapping.Split("{$*$}")[0];
                var value = mapping.Split("{$*$}")[1];
                SessionStorage.typeTimeMappings.Add(key, value);
            }

            UpdateMeetingTypes();

            meetingDate.Value = DateTime.Now;
        }

        private void meetingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            meetingTime.Text = SessionStorage.typeTimeMappings[meetingType.Items[meetingType.SelectedIndex].ToString()];
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(meetingType.Text) ||
                string.IsNullOrEmpty(meetingTime.Text)
                )
            {
                MessageBox.Show("Fill in Meeting Type and Time", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!string.IsNullOrEmpty(meetingInfo.Text) && meetingInfo.Lines.Length != 2)
            {
                MessageBox.Show("Meeting Info should contain 2 lines", "Error", MessageBoxButtons.OK);
                return;
            }


            SessionStorage.report.Name = meetingType.Text;
            SessionStorage.report.Link = meetingLink.Text;
            SessionStorage.report.Date = meetingDate.Value;
            SessionStorage.report.Time = meetingTime.Text;
            SessionStorage.report.MeetingInfo = meetingInfo.Text;
            SessionStorage.report.Location = meetingLocation.Text;
            SessionStorage.report.Questions = questions.Lines.ToList();
            SessionStorage.report.InternalNotes = internalNotes.Lines.ToList();
            SessionStorage.report.Tickets = ticketsDisplay.Items.Cast<Ticket>().ToList();

            outputTextBox.Text = SessionStorage.report.GetReport();

        }

        private void btn_addTicket_Click(object sender, EventArgs e)
        {
            var createTicketForm = new TicketForm();
            var result = createTicketForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (createTicketForm.Ticket != null)
                {
                    ticketsDisplay.Items.Add(createTicketForm.Ticket);
                }

            }
        }

        private void btn_editTicket_Click(object sender, EventArgs e)
        {
            if (ticketsDisplay.SelectedIndex != -1)
            {
                var selectedTicket = ticketsDisplay.Items[ticketsDisplay.SelectedIndex] as Ticket;
                var createTicketForm = new TicketForm(selectedTicket);
                var result = createTicketForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (createTicketForm.Ticket != null)
                    {
                        ticketsDisplay.Items[ticketsDisplay.SelectedIndex] = createTicketForm.Ticket;
                    }
                }
            }
        }

        private void ticketsDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.ticketsDisplay.SelectedItem == null) return;
            this.ticketsDisplay.DoDragDrop(this.ticketsDisplay.SelectedItem, DragDropEffects.Move);

        }

        private void ticketsDisplay_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void ticketsDisplay_DragDrop(object sender, DragEventArgs e)
        {
            Point point = ticketsDisplay.PointToClient(new Point(e.X, e.Y));
            int index = this.ticketsDisplay.IndexFromPoint(point);
            if (index < 0) index = this.ticketsDisplay.Items.Count - 1;
            object data = e.Data.GetData(typeof(Ticket));
            this.ticketsDisplay.Items.Remove(data);
            this.ticketsDisplay.Items.Insert(index, data);
        }

        private void btn_deleteTicket_Click(object sender, EventArgs e)
        {
            if (ticketsDisplay.SelectedIndex != -1)
            {
                ticketsDisplay.Items.RemoveAt(ticketsDisplay.SelectedIndex);
            }
        }

        private void btn_timeNow_Click(object sender, EventArgs e)
        {
            meetingDate.Value = DateTime.Now;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.JiraTicketChecked = SessionStorage.JiraCheckedDefault;
            Settings.Default.TypeTimeMappings.Clear();
            Settings.Default.TypeTimeMappings.AddRange(SessionStorage.typeTimeMappings.Select(el => $"{el.Key}{{$*$}}{el.Value}").ToArray());
            Settings.Default.Save();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.StartPosition = FormStartPosition.CenterParent;
            settingsForm.ShowDialog();
            UpdateMeetingTypes();
        }
    }
}
