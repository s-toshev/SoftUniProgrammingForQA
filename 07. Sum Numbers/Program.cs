namespace _07._Sum_Numbers
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
              

           int num = int.Parse(Console.ReadLine());

            for (int i = num; i >= 1; i--) { 
            Console.WriteLine(i);
            }

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i += 3)
            {
                Console.WriteLine(i);
            }

            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= num; i+=2) {
                Console.WriteLine(Math.Pow(2,i));
            }

            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }

            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (currentChar == 'a')
                {
                    sum = sum + 1;
                }else if(currentChar == 'e')
                {
                    sum = sum + 2;
                }else if( currentChar == 'i')
                {
                    sum = sum + 3;
                }else if(currentChar== 'o')
                {
                    sum = sum + 4;
                }else if (currentChar == 'u')
                {
                    sum = sum + 5;
                }
            }
            Console.WriteLine(sum); */



            int sum = 0;
            int nNumbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine(sum);


            /*
            int nNumbers = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;
            for (int i = 1; i <= nNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > maxNum)
                {
                    maxNum = currentNumber;
                }

                if (currentNumber < minNum)
                {
                    minNum = currentNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}"); */
        }
    }
}
