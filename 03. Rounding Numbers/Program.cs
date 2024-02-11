namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] textInput = Console.ReadLine().Split();
            double[] numArr = new double[textInput.Length];

            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = double.Parse(textInput[i]);
            }

            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] == -0)
                {
                    numArr[i] = 0;
                }
                Console.WriteLine($"{numArr[i]} => {Math.Round(numArr[i], MidpointRounding.AwayFromZero)}");
            }

        }
    }
}