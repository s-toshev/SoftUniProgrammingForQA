namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Student> studentsList = new List<Student>();

            while (command != "end")
            {
                string[] input = command.Split(" ");

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string homeTown = input[3];

                Student newStudent = new Student(firstName, lastName, age, homeTown);

                studentsList.Add(newStudent);

                command = Console.ReadLine();
            }

            string townToWrite = Console.ReadLine();

            studentsList = studentsList
                .Where(newStudent => newStudent.HomeTown == townToWrite).ToList();

            foreach (Student student in studentsList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} " +
                    $"is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }


        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
    }

}