namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            Array.Reverse(arr);


            Console.Write(String.Join(" ", arr));

        }
    }
}