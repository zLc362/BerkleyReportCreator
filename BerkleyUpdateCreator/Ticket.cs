using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerkleyUpdateCreator
{
    public class Ticket
    {
        public int Order { get; set; }
        public string Link { get; set; }
        public string Name { get; set; }
        public string TicketId { get; set; }
        public List<string> Updates { get; set; } = new List<string>();

        public Ticket(string[] LinkField, string[] UpdatesField,int order) {
            if (LinkField.Length < 2) return;
            Link = LinkField[0];
            Name = LinkField[1];
            Order = order;
            TicketId = Link.Split('/').Last();
            if (UpdatesField != null)
            {
                Updates = UpdatesField.ToList();
            }
        }
        public string GetFormattedTicket()
        {
            if (TicketId == null)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"### Task {Order}: [{TicketId} {Name}]({Link})");
            if(Updates == null || Updates.Count == 0)
            {
                sb.AppendLine("- ");
            }
            foreach (var update in Updates)
            {
                sb.AppendLine($"- {update}");
            }
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
