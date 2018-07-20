using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class TargetPosition
    {
        public TargetPosition()
        {
        }

        public TargetPosition(string position, List<string> reasons)
        {
            Position = position;
            Reasons = reasons;
        }

        public string Position { get; set; }
        public List<string> Reasons { get; set; }
    }
}
