using BerkleyUpdateCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerkleyUpdateCreator
{
    public static class SessionStorage
    {
        public static Report report { get; set; } = new Report();
        public static Dictionary<string, string> typeTimeMappings = new Dictionary<string, string>();
        public static bool JiraCheckedDefault = false;
    }
}
