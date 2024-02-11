namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(x, y));
        }

        static double MathPower(double x, double y)
        {
            double result = Math.Pow(x, y);

            return result;
        }

    }
}