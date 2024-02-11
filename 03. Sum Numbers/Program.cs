namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num > sum)
            {

                int num1 = int.Parse(Console.ReadLine());
                sum = sum + num1;

            }
            Console.WriteLine(sum);
        }
    }
}
