namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            List<string> list = text.Split().ToList();
            List<int> numbers = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                numbers.Add(int.Parse(list[i]));
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> input = command.Split().ToList();

                if (input[0] == "Add")
                {
                    int numToAdd = int.Parse(input[1]);
                    numbers.Add(numToAdd);
                }
                else if (input[0] == "Remove")
                {
                    int numToRemove = int.Parse(input[1]);
                    numbers.Remove(numToRemove);
                }
                else if (input[0] == "RemoveAt")
                {
                    int indexToRemove = int.Parse(input[1]);
                    numbers.RemoveAt(indexToRemove);
                }
                else if (input[0] == "Insert")
                {
                    int valueToInsertAtIndex = int.Parse(input[1]);
                    int insertIndex = int.Parse(input[2]);
                    numbers.Insert(insertIndex, valueToInsertAtIndex);
                }


                command = Console.ReadLine();
            }


            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}