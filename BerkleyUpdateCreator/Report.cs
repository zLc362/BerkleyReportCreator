using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerkleyUpdateCreator
{
    public class Report
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Time {  get; set; }
        public string Link { get; set; }
        public string MeetingId { get; set; }
        public string MeetingPassword { get; set; }
        public string Location { get; set; }
        public Ticket Ticket1 { get; set; }
        public Ticket Ticket2 { get; set; }
        public Ticket Ticket3 { get; set; }
        public List<string> InternalNotes { get; set; }
        public List<string> Questions { get; set; }

        public string GetReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"# {Date.Day}.{Date.Month} Berkley Update (Official)");
            sb.AppendLine();

            sb.Append(Ticket1.GetFormattedTicket());
            sb.Append(Ticket2.GetFormattedTicket());
            sb.Append(Ticket3.GetFormattedTicket());
            
            sb.AppendLine($"### Internal Notes:");
            if (InternalNotes == null || InternalNotes.Count==0)
            {
                sb.AppendLine("- ");
            }
            else
            {
                InternalNotes.ForEach(note => sb.AppendLine($"- {note}"));
            }
            sb.AppendLine();

            sb.AppendLine($"### Questions:");
            if (Questions==null || Questions.Count==0)
            {
                sb.AppendLine("- ");
            }
            else
            {
                Questions.ForEach(question => sb.AppendLine($"- {question}"));
            }
            sb.AppendLine();

            sb.AppendLine($"### Meeting Info:");
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Time: {Time}");
            sb.AppendLine($"Link: {Link}");
            sb.AppendLine($"Meeting ID: {MeetingId.Split(':')[1]}");
            sb.AppendLine($"Passcode: {MeetingPassword.Split(':')[1]}");
            sb.AppendLine($"Location: {Location}");

            return sb.ToString();
        }
    }
}
