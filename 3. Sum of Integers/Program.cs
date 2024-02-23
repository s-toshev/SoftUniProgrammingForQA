
namespace _3._Sum_of_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();

            int sum = 0;
            foreach (var item in list)
            {
                try
                {

                    int element = int.Parse(item);
                    sum += element;


                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{item}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{item}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{item}' processed - current sum: {sum}");

                }

            }

            Console.WriteLine($"The total sum of all integers is: {sum}");

        }
    }
}
