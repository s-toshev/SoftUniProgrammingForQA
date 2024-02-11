using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            StringBuilder sb = new StringBuilder();

            foreach (string s in input)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    sb.Append(s);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}