namespace _02._Numbers_Nto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
              for (int i = 1; i <=100; i++)
              {
                  Console.WriteLine(i);
              }
              */

            int num = int.Parse(Console.ReadLine());

            for (int i = num; i >= 1; i--)
            {
                Console.WriteLine(i);
            }


        }
    }
}
