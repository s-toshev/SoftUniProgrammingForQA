namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();

            if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(num1, num2));
            }
            else if (type == "char")
            {
                char one = char.Parse(Console.ReadLine());
                char two = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(one, two));
            }
            else if (
                type == "string")
            {
                string str = Console.ReadLine();
                string str1 = Console.ReadLine();

                Console.WriteLine(GetMax(str, str1));
            }

        }


        static int GetMax(int value, int value1)
        {

            if (value > value1)
            {
                return value;
            }
            else
            {
                return value1;
            }


        }

        static char GetMax(char value, char value1)
        {

            if (value > value1)
            {
                return value;
            }
            else
            {
                return value1;
            }

        }

        static string GetMax(string value, string value1)
        {

            if (value.CompareTo(value1) > 0)
            {
                return value;
            }
            else
            {
                return value1;
            }

        }

    }
}