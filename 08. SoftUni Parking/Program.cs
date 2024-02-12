namespace _08._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCOmmands = int.Parse(Console.ReadLine());


            Dictionary<string, string> registrars = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCOmmands; i++)
            {
                string input = Console.ReadLine();

                string[] data = input.Split().ToArray();

                string command = data[0];
                string user = data[1];

                if (command == "register")
                {
                    string licensePlate = data[2];

                    if (!registrars.ContainsKey(user))
                    {
                        registrars.Add(user, licensePlate);
                        Console.WriteLine($"{user} registered " +
                            $"{licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with" +
                            $" plate number {licensePlate}");
                    }
                }
                else if (command == "unregister")
                {

                    if (!registrars.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        registrars.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");

                    }
                }
            }


            foreach (var item in registrars)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}