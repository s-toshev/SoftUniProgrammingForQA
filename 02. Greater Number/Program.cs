namespace _02._Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*   double grade = double.Parse(Console.ReadLine());

               if (grade >= 5.50) {
                   Console.WriteLine("Excellent!");
               }*/

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else { Console.WriteLine(num2); }

        }
    }
}
