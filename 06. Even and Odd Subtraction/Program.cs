namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            int[] numArr = new int[text.Length];
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = int.Parse(text[i]);
            }

            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] % 2 == 0)
                {
                    evenSum += numArr[i];
                }
                else
                {
                    oddSum += numArr[i];
                }
            }

            Console.WriteLine($"{evenSum - oddSum}");

        }
    }
}