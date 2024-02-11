namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1 = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(MathOperations(num1, @operator, num2));

        }

        static double MathOperations(double a, string @operator, double b)
        {
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = Math.Abs(a / b);
                    break;
                case "*":
                    result = Math.Abs(a * b);
                    break;

                case "+":
                    result = Math.Abs(a + b);
                    break;

                case "-":
                    result = Math.Abs(a - b);
                    break;


            }

            return result;
        }

    }
}