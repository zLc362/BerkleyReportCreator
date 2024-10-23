namespace BerkleyUpdateCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            meetingDate.Value = DateTime.Now;
            meetingType.SelectedIndex = 0;
        }

        private void meetingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (meetingType.SelectedIndex)
            {
                case 0: meetingTime.Text = "15:30 - 15:45"; break;
                case 1: meetingTime.Text = "15:30 - 17:30"; break;
                case 2: meetingTime.Text = "15:00 - 17:00"; break;
            }
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(meetingType.Text) ||
                string.IsNullOrEmpty(meetingLink.Text) ||
                string.IsNullOrEmpty(meetingTime.Text) ||
                string.IsNullOrEmpty(meetingInfo.Text) ||
                string.IsNullOrEmpty(meetingLocation.Text) ||
                meetingInfo.Lines.Length < 2
                )
            {
                MessageBox.Show("Fill in all Meeting info fields", "Error", MessageBoxButtons.OK);
                return;
            }

            var Report = new Report
            {
                Name = meetingType.Text,
                Link = meetingLink.Text,
                Date = meetingDate.Value,
                Time = meetingTime.Text,
                MeetingId = meetingInfo.Lines[0],
                MeetingPassword = meetingInfo.Lines[1],
                Location = meetingLocation.Text,
                Ticket1 = new Ticket(ticketLink1.Lines, ticketDescription1.Lines, 1),
                Ticket2 = new Ticket(ticketLink2.Lines, ticketDescription2.Lines, 2),
                Ticket3 = new Ticket(ticketLink3.Lines, ticketDescription3.Lines, 3),
                Questions = questions.Lines.ToList(),
                InternalNotes = internalNotes.Lines.ToList(),
            };

            outputTextBox.Text = Report.GetReport();

        }
    }
}
