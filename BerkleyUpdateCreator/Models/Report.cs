using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerkleyUpdateCreator.Models
{
    public class Report
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string? Link { get; set; }
        public string? MeetingInfo { get; set; }
        public string? Location { get; set; }
        public List<Ticket> Tickets { get; set; } = [];
        public List<string> InternalNotes { get; set; } = [];
        public List<string> Questions { get; set; } = [];

        private string lineString(string input) => $"- {input}";

        private string[] displayTasks(bool condition, string[] ifTrue, string[] ifFalse)
        {
            return condition ? ifTrue : ifFalse;
        }
        public string GetReport()
        {
            return $"""
            # {Date.Day}.{Date.Month} Berkley Update (Official)

            ### Tasks:
            {String.Join("\n", (Tickets.Count > 0 ? Tickets.Select(ticket => ticket.GetFormattedTicket()).ToArray() : ["- "]))}

            ### Internal Notes:
            {String.Join("\n", (InternalNotes.Count > 0 ? (InternalNotes.Select(lineString).ToArray()) : ["- "]))}

            ### Questions:
            {String.Join("\n", (Questions.Count > 0 ? Questions.Select(lineString).ToArray() : ["- "]))}

            ### Meeting Info:
            Name: {Name}
            Time: {Time}
            {String.Join("\n", new List<string>() {
                    (!String.IsNullOrEmpty(Link) ? $"Link: {Link}\n" : String.Empty),
                    (!String.IsNullOrEmpty(MeetingInfo) ? MeetingInfo : String.Empty),
                    (!String.IsNullOrEmpty(Location) ? $"Location: {Location}" : String.Empty)
                }.Where(line => !String.IsNullOrEmpty(line)))}
            """;
        }
    }
}
