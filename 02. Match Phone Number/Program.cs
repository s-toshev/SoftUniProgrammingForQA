using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string filter = @"\+359( |-)2\1(\d{3})\1(\d{4})\b";

            Regex regex = new Regex(filter);

            MatchCollection matches = regex.Matches(input);

            Console.WriteLine(String.Join(", ", matches));

        }
    }
}