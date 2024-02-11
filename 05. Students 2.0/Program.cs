namespace _05._Students_2._0
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }


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
                string city = input[3];


                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = city;

                studentsList.Add(student);

                command = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            List<Student> filteredStudents = studentsList
                .DistinctBy(student => new { student.FirstName, student.LastName }).ToList();

            List<Student> filteredStudents2 = filteredStudents
               .Where(student => student.HomeTown == cityName)
               .ToList();

            foreach (Student student in filteredStudents2)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} " +
                    $"is {student.Age} years old.");
            }

        }
    }
}