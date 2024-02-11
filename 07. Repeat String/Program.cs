namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(RptString(text, num));


        }


        static string RptString(string text, int num)
        {
            string result = String.Empty;

            for (int i = 0; i < num; i++)
            {

                result += text;

            }

            return result;

        }

    }
}