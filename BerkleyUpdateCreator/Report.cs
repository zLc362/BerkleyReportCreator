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
        public string? Link { get; set; }
        public string? MeetingInfo { get; set; }
        public string? Location { get; set; }
        public List<Ticket> Tickets { get; set; } = [];
        public List<string> InternalNotes { get; set; } = [];
        public List<string> Questions { get; set; } = [];

        public string GetReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"# {Date.Day}.{Date.Month} Berkley Update (Official)");
            sb.AppendLine();
            sb.AppendLine($"### Tasks:");
            if (Tickets == null || Tickets.Count == 0)
            {
                sb.AppendLine("- ");
            }
            else
            {
                for (int i = 0; i < Tickets.Count; i++)
                {
                    sb.AppendLine(Tickets[i].GetFormattedTicket(i+1));
                }
            }
            
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
            if (!String.IsNullOrEmpty(Link)) sb.AppendLine($"Link: {Link}");
            if (!String.IsNullOrEmpty(MeetingInfo)) sb.AppendLine(MeetingInfo);
            if (!String.IsNullOrEmpty(Location)) sb.AppendLine($"Location: {Location}");

            return sb.ToString();
        }
    }
}
