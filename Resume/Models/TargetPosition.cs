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

        public TargetPosition(string position, List<string> reasons)
        {
            Position = position;
            Reasons =  new ObservableCollection<string>(reasons);
        }

        public string Position { get; set; }
        public ObservableCollection<string> Reasons { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
