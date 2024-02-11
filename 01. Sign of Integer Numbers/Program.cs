namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SignChecker(int.Parse(Console.ReadLine()));
        }

        static void SignChecker(int number)
        {

            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");

            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }

        }

    }
}