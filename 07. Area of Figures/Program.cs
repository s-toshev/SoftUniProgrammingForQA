namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*   double grade = double.Parse(Console.ReadLine());

               if (grade >= 5.50) {
                   Console.WriteLine("Excellent!");
               }*/

            /* int num1 = int.Parse(Console.ReadLine());
             int num2 = int.Parse(Console.ReadLine());

             if(num1 > num2) {
                 Console.WriteLine(num1);
             }else { Console.WriteLine(num2);} */

            /*   int num1 = int.Parse(Console.ReadLine());

               if (num1 % 2 == 0)
               {
                   Console.WriteLine("even");
               }
               else
                   Console.WriteLine("odd"); */


            /* String password = Console.ReadLine();

             if (password == "s3cr3t!P@ssw0rd"){
                 Console.WriteLine("Welcome");
             }else
             {
                 Console.WriteLine("Wrong password!");
             } 

            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speed > 10 && speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speed > 50 && speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed > 150 && speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else { Console.WriteLine("extremely fast"); } */

            string typeOfFigure = Console.ReadLine();

            if (typeOfFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double result = side * side;
                Console.WriteLine($"{result:F3}");
            }
            else if (typeOfFigure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double result = side1 * side2;
                Console.WriteLine($"{result:F3}");
            }
            else if (typeOfFigure == "circle")
            {
                double rad = double.Parse(Console.ReadLine());
                double result = Math.PI * (rad * rad);
                Console.WriteLine($"{result:F3}");
            }
            else if (typeOfFigure == "triangle")
            {
                double side1 = double.Parse((Console.ReadLine()));
                double side2 = double.Parse((Console.ReadLine()));
                double result = 0.5 * (side1 * side2);
                Console.WriteLine($"{result:F3}");
            }
        }
    }
}
