namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] text = Console.ReadLine().Split();

            Array.Reverse(text);

            Console.WriteLine(String.Join(" ", text));
        }
    }
}