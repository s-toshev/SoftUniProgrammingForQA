namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(one))
            {
                text = text.Replace(one, "");
            }

            Console.WriteLine(text);
        }
    }
}