using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Experience : INotifyPropertyChanged
    {
        public Experience()
        {
        }

        public Experience(string firm, DateTime since, DateTime until, string position, string duties, string extra)
        {
            Firm = firm;
            Since = since;
            Until = until;
            Position = position;
            Duties = duties;
            Extra = extra;
        }

        public string Firm { get; set; }
        public DateTime Since { get; set; } = DateTime.Now;
        public DateTime Until { get; set; } = DateTime.Now;
        public string Position { get; set; }
        public string Duties { get; set; }
        public string Extra { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
