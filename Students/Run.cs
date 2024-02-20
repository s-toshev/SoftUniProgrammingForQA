namespace Students
{
    internal class Run
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();

            List<Students> list = new List<Students>();

            while (command != "end")
            {
                string[] input = command.Split(" ").ToArray();
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string city = input[3];

                Students currentStudent = new (firstName, lastName, age, city);
                list.Add(currentStudent);


                command = Console.ReadLine();
            }

            string givenCity = Console.ReadLine();

            List<Students> filteredList = list.Where(s => s.GetHomeTown().Equals(givenCity)).ToList();

            foreach(Students student in filteredList)
            {
                Console.WriteLine($"{student.GetFirstName()} {student.GetLastName()} is {student.GetAge()} years old.");
            }
        }
    }
}
