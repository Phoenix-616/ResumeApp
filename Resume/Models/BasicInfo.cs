using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class BasicInfo
    {
        public BasicInfo() { }
        public BasicInfo(string firstName, string middleName, string lastName, bool male, DateTime birthDay, string phone, string email)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool Male { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}
