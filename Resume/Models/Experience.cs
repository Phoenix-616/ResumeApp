using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Experience
    {
        public Experience()
        {
        }

        public Experience(string firm, DateTime since, DateTime until, string position, List<string> duties, string extra)
        {
            Firm = firm;
            Since = since;
            Until = until;
            Position = position;
            Duties = duties;
            Extra = extra;
        }

        public string Firm { get; set; }
        public DateTime Since { get; set; }
        public DateTime Until { get; set; }
        public string Position { get; set; }
        public List<string> Duties { get; set; }
        public string Extra { get; set; }
    }
}
