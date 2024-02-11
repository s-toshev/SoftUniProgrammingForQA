namespace _01.Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] arr =
                {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 7)
            {
                Console.WriteLine(arr[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }


        }
    }
}