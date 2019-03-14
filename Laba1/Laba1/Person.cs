using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Laba1
{
    public class Person
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private DateTime DateOfBirth { get; set; }

        public Person()
        {
            Name = "None";
            Surname = "None";
            DateOfBirth = new DateTime(1997, 10, 15);
        }

        public Person(string newName, string newSurname, DateTime Date)
        {
            Name = newName;
            Surname = newSurname;
            DateOfBirth = Date;
        }

        int ChangeDateOfBirth
        {
            get
            {
                return DateOfBirth.Year;
            }
            set
            {
                DateOfBirth = new DateTime(value, DateOfBirth.Month, DateOfBirth.Day);
            }
        }

        public override string ToString()
        {
            return Name + " " + Surname + " " + DateOfBirth;
        }
        

        public string ToShortString()
        {
            return Name + " " + Surname;
        }

        public enum Education
        {
            Master,
            Bachelor,
            SecondEducation
        }

    }
}
