
namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i <= n; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                sum1 = sum1 + n1;
            }

            for (int i = 1; i <= n; i++)
            {
                int n2 = int.Parse(Console.ReadLine());
                sum2 = sum2 + n2;
            }

            if (sum1 != sum2)
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }
            else if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
        }
    }
}
