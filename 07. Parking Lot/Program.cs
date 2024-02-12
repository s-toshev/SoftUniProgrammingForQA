namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> set = new HashSet<string>();

            while (command != "END")
            {
                string[] input = command.Split(", ");

                string action = input[0];
                string carPlate = input[1];

                if (action == "IN")
                {
                    set.Add(carPlate);
                }
                else
                {
                    set.Remove(carPlate);
                }

                if (set.Count == 0)
                {
                    Console.WriteLine("Parking Lot is Empty");
                    break;
                }


                command = Console.ReadLine();
            }

            foreach (string line in set)
            {
                Console.WriteLine(line);
            }

        }
    }
}