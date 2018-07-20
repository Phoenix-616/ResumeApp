using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Skill : INotifyPropertyChanged, IDisposable
    {
        public Skill() { }

        public Skill(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void Dispose()
        {
            Name = null;
            Description = null;
        }
    }
}
