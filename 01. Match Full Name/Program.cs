using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string filter = @"\b([A-Z][a-z]{1,}) ([A-Z][a-z]{1,})\b";

            Regex regex = new Regex(filter);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }

        }
    }
}