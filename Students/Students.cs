using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Students
    {
        private string FirstName {  get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }
        private string HomeTown { get; set; }

        public Students(string firstName, string lastName, int age, string homeTown)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Age = age;
            this.HomeTown = homeTown;
            
        }

        public string GetFirstName()
        {
            return this.FirstName;
        }

        public string GetLastName()
        {
            return this.LastName;
        }

        public int GetAge()
        {
            return this.Age;
        }

        public string GetHomeTown()
        {
            return this.HomeTown;
        }
    }
}
