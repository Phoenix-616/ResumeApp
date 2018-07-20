using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Models
{
    public enum AcDegree { None, Bachelor, Master, PhD, Doctor }
    public class Education : INotifyPropertyChanged, IDisposable
    {
        public Education() { }

        public Education(string uniName, string department, bool done, AcDegree degree)
        {
            UniName = uniName;
            Department = department;
            Done = done;
            Degree = degree;
        }

        public string UniName { get; set; }
        public string Department { get; set; }
        public bool Done { get; set; }
        public AcDegree Degree { get; set; } = AcDegree.None;
        public event PropertyChangedEventHandler PropertyChanged;
        public void Dispose()
        {
            UniName = null;
            Department = null;
            Degree = AcDegree.None;
        }
    }
}
