using System.Windows.Forms;

namespace BerkleyUpdateCreator
{
    public partial class MainForm : Form
    {
        public Report report { get; set; }
        public MainForm()
        {
            InitializeComponent();
            report = new Report();

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
                case 3: meetingTime.Text = "15:00 - 17:30"; break;
            }
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


            report.Name = meetingType.Text;
            report.Link = meetingLink.Text;
            report.Date = meetingDate.Value;
            report.Time = meetingTime.Text;
            report.MeetingInfo = meetingInfo.Text;
            report.Location = meetingLocation.Text;
            report.Questions = questions.Lines.ToList();
            report.InternalNotes = internalNotes.Lines.ToList();
            report.Tickets = ticketsDisplay.Items.Cast<Ticket>().ToList();

            outputTextBox.Text = report.GetReport();

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

        private void ticketsDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
