namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input;
            int minNum = int.MaxValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int num = int.Parse(input);

                if (num < minNum)
                {
                    minNum = num;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
