using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Skill : INotifyPropertyChanged
    {
        public Skill() { }

        public Skill(string description)
        {
            Description = description;
        }
        public string Description { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
