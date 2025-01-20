using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BerkleyUpdateCreator.Models;

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
                cbx_jiraTicketTitle.Checked = Ticket.IsJira;
                cbx_story.Checked = Ticket.IsStory;
                if (Ticket.IsJira)
                {
                    ticketLink1.Lines = [Ticket.Link, Ticket.Name];
                }
                else
                {
                    ticketLink1.Lines = [Ticket.titleInput];
                }
                ticketDescription1.Lines = [.. Ticket.Updates];
            }else
            {
                cbx_jiraTicketTitle.Checked = SessionStorage.JiraCheckedDefault;
            }
        }

        private void btn_SubmitTicket_Click(object sender, EventArgs e)
        {
            var isJira = cbx_jiraTicketTitle.Checked;
            if (String.IsNullOrEmpty(ticketLink1.Text) ||
                (isJira &&
                    (ticketLink1.Lines.Length != 2 ||
                    String.IsNullOrEmpty(ticketLink1.Lines[0]) ||
                    String.IsNullOrEmpty(ticketLink1.Lines[1]))))
            {
                if (isJira)
                {
                    MessageBox.Show("Fill in Ticket Title And Link", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Fill in Ticket Title", "Error", MessageBoxButtons.OK);
                }
                return;
            }
            if (isJira)
            {
                Ticket = new Ticket(ticketLink1.Lines, ticketDescription1.Lines);
            }
            else
            {
                Ticket = new Ticket(ticketLink1.Text, ticketDescription1.Lines);
            }

            Ticket.IsStory = cbx_story.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
