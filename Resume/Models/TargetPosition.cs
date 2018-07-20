using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class TargetPosition : INotifyPropertyChanged
    {

        public TargetPosition()
        {
        }

        public TargetPosition(string position, string reasons)
        {
            Position = position;
            Reasons = reasons;
        }

        public string Position { get; set; }
        public string Reasons { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
