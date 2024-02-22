namespace _1._Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());

                if(num < 0)
                {
                    Console.WriteLine("Invalid number.");
                }
                else{
                    double sqRoot = Math.Sqrt(num);
                    Console.WriteLine(sqRoot);

                }

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number.");

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Goodbye.");

            }


        }
    }
}
