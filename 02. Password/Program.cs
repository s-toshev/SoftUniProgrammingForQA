namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string username = Console.ReadLine();
            string realPassword = Console.ReadLine();
            string inputPassword = "";

            while (realPassword != inputPassword)
            {
                inputPassword = Console.ReadLine();

                if (realPassword == inputPassword)
                {
                    Console.WriteLine($"Welcome {username}!");
                }


            }
        }
    }
}
