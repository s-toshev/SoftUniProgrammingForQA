namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int h = int.Parse(Console.ReadLine());


            for (int i = 1; i <= h; i++)
            {
                PrintTriangle(1, i);
            }

            for (int i = h - 1; i >= 1; i--)
            {
                PrintTriangle(1, i);
            }
        }

        static void PrintTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {

                Console.Write($"{i} ");

            }
            Console.WriteLine();



        }


    }
}