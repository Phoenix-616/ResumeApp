using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Resume.Models
{
    public class Person : INotifyPropertyChanged
    {
        public Person()
        {
            Info = new BasicInfo();
            HighSchools = new ObservableCollection<Education>();
            Skills = new ObservableCollection<Skill>();
            TargetPositions = new ObservableCollection<TargetPosition>();
            Experiences = new ObservableCollection<Experience>();
        }

        public Person(BasicInfo info, List<Education> highSchools,
            List<Skill> skills, List<TargetPosition> targetPositions,
            List<Experience> experiences)
        {
            Info = info;
            HighSchools = new ObservableCollection<Education>(highSchools);
            Skills = new ObservableCollection<Skill>(skills);
            TargetPositions = new ObservableCollection<TargetPosition>(targetPositions);
            Experiences = new ObservableCollection<Experience>(experiences);
        }

        public BasicInfo Info { get; set; }
        public ObservableCollection<Education> HighSchools { get; set; }
        public ObservableCollection<Skill> Skills { get; set; }
        public ObservableCollection<TargetPosition> TargetPositions { get; set; }
        public ObservableCollection<Experience> Experiences { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public void Reload(Person obj)
        {
            Info = obj.Info;
            HighSchools = obj.HighSchools;
            Skills = obj.Skills;
            TargetPositions = obj.TargetPositions;
            Experiences = obj.Experiences;
        }
    }
}
