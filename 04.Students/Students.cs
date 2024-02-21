using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Students
{
    public class Students
    {

        private string _firstName;
        private string _lastName;
        private double _grade;

        public string FirstName { get {return _firstName; } set { _firstName = value; } }

        public string LastName { get { return _lastName; } set { _lastName = value; } }

        public double Grade { get { return _grade; } set { _grade = value; } }

        public Students(string firstName, string lastName, double grade)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Grade = grade;
        }
    }
}
