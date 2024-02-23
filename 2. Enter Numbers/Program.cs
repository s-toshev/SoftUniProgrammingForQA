using System.Text;

namespace _2._Enter_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> ints = new List<int>();
            int prevNum = 1;

            while (ints.Count < 10)
            {
                try
                {
                    int num = ReadNumber(prevNum, 100);

                    ints.Add(num);
                    prevNum = num;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"Your number is not in range " +
                        $"{prevNum} - 100!");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }
            Console.WriteLine(String.Join(", ", ints));
        }

        static int ReadNumber(int start, int end)
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= start || num >= end)
            {
                throw new ArgumentException();
            }

            return num;
        }
    }
}