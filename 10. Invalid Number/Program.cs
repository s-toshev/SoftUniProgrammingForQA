namespace _10._Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isValid = num == 0 || num >= 100 & num <= 200;

            if (!isValid)
            {
                Console.WriteLine("invalid");

            }
        }
    }
}
