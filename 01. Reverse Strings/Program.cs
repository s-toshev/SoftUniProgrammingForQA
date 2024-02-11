using System.Text;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            while (command != "end")
            {
                for (int i = command.Length - 1; i >= 0; i--)
                {
                    sb.Append(command[i]);
                }
                Console.WriteLine($"{command} = {sb.ToString()}");
                sb.Clear();
                command = Console.ReadLine();
            }
        }
    }
}