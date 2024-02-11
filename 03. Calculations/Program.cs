namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Calculations(action, num1, num2);

        }

        static void Calculations(string action, int num1, int num2)
        {
            int result = 0;

            if (action == "add")
            {
                result = num1 + num2;
            }
            else if (action == "multiply")
            {
                result = num1 * num2;
            }
            else if (action == "subtract")
            {
                result = num1 - num2;
            }
            else if (action == "divide")
            {
                result = num1 / num2;
            }

            Console.WriteLine(result);
        }

    }
}