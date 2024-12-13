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
    public partial class TicketForm : Form
    {
        public Ticket? Ticket { get; set; }
        public TicketForm(Ticket? ticket = null)
        {
            InitializeComponent();
            Ticket = ticket;
            if (Ticket != null)
            {
                ticketLink1.Text=Ticket.titleInput;
                ticketDescription1.Lines = [.. Ticket.Updates];
            }
        }

        private void btn_SubmitTicket_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ticketLink1.Text))
            {
                MessageBox.Show("Fill in Ticket Title", "Error", MessageBoxButtons.OK);
                return;
            }
            var isJira = cbx_jiraTicketTitle.Checked;
            if (isJira)
            {
                Ticket = new Ticket(ticketLink1.Lines,ticketDescription1.Lines);
            }
            else
            {
                Ticket = new Ticket(ticketLink1.Text, ticketDescription1.Lines);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
