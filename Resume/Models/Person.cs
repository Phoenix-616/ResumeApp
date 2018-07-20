using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Resume.Models
{
    public class Person
    {
        public Person()
        {
        }

        public Person(BasicInfo info, List<Education> highSchools, List<Skill> skills, List<TargetPosition> targetPositions, List<Experience> experiences)
        {
            Info = info;
            HighSchools = highSchools;
            Skills = skills;
            TargetPositions = targetPositions;
            Experiences = experiences;
        }

        public BasicInfo Info { get; set; }
        public List<Education> HighSchools { get; set; }
        public List<Skill> Skills { get; set; }
        public List<TargetPosition> TargetPositions { get; set; }
        public List<Experience> Experiences { get; set; }
    }
}
