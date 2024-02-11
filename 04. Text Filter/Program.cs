using System.Text;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            string replacedText = "";

            for (int i = 0; i < banWords.Length; i++)
            {
                foreach (var element in banWords[i])
                {
                    sb.Append("*");
                }
                string asteriks = sb.ToString();

                replacedText = text.Replace(banWords[i], asteriks);
                text = replacedText;

                sb.Clear();

            }

            Console.WriteLine(replacedText);
        }
    }
}