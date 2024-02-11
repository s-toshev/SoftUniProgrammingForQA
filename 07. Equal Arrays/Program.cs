namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text1 = Console.ReadLine().Split();
            int[] numArr1 = new int[text1.Length];

            for (int i = 0; i < text1.Length; i++)
            {
                numArr1[i] = int.Parse(text1[i]);
            }



            string[] text2 = Console.ReadLine().Split();
            int[] numArr2 = new int[text2.Length];

            for (int i = 0; i < text2.Length; i++)
            {
                numArr2[i] = int.Parse(text2[i]);
            }

            int arrSum = 0;
            bool areEqual = false;
            int stop = 0;

            if (numArr1.Length > numArr2.Length)
            {
                Console.WriteLine($"Arrays are not identical. " +
                    $"Found difference at {numArr2.Length} index.");
            }
            else if (numArr1.Length < numArr2.Length)
            {
                Console.WriteLine($"Arrays are not identical. " +
                   $"Found difference at {numArr1.Length} index.");
            }
            else if (numArr1.Length == numArr2.Length)
            {
                for (int i = 0; i < numArr1.Length; i++)
                {
                    arrSum += numArr1[i];

                    if (numArr1[i] == numArr2[i])
                    {
                        areEqual = true;
                    }
                    else
                    {
                        areEqual = false;
                        stop = i;
                        break;
                    }
                }
            }

            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical." +
                           $" Sum: {arrSum}");

            }
            else if (areEqual == false)
            {
                Console.WriteLine($"Arrays are not identical. " +
                    $"Found difference at {stop} index");
            }


        }
    }
}