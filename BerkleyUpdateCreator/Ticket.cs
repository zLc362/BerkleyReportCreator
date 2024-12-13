using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerkleyUpdateCreator
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string titleInput { get; set; }
        public int? Order { get; set; }
        public string? Link { get; set; }
        public string Name { get; set; }
        public string? TicketId { get; set; }
        public List<string> Updates { get; set; } = new List<string>();

        public Ticket(string[] LinkField, string[] UpdatesField) {
            Id = Guid.NewGuid();
            if (LinkField.Length < 2) return;
            Link = LinkField[0];
            Name = LinkField[1];
            TicketId = Link.Split('/').Last();
            if (UpdatesField != null)
            {
                Updates = UpdatesField.ToList();
            }
            titleInput = String.Join("\n", LinkField);
        }
        public Ticket(string Title, string[] Updates) {
            titleInput = Title;
            Name = Title;
            if (Updates != null)
            {
                this.Updates = Updates.ToList();
            }
        }
        public string GetFormattedTicket(int? order = null)
        {
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrEmpty(Link))
            {
                sb.AppendLine($"### Task{(order==null ? "" : " "+order)}: {Name}");
            }
            else if (TicketId == null)
            {
                return string.Empty;
            }else
            {
                sb.AppendLine($"### Task {Order}: [{TicketId} {Name}]({Link})");

            }
            
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

        public override string? ToString()
        {
            return Name;
        }
    }
}
