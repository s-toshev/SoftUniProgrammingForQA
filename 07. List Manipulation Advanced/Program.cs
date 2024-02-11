namespace _07._List_Manipulation_Advanced
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
            bool isChanged = false;

            while (command != "end")
            {
                List<string> input = command.Split().ToList();

                if (input[0] == "Add")
                {
                    int numToAdd = int.Parse(input[1]);
                    numbers.Add(numToAdd);
                    isChanged = true;
                }
                else if (input[0] == "Remove")
                {
                    int numToRemove = int.Parse(input[1]);
                    numbers.Remove(numToRemove);
                    isChanged = true;
                }
                else if (input[0] == "RemoveAt")
                {
                    int indexToRemove = int.Parse(input[1]);
                    numbers.RemoveAt(indexToRemove);
                    isChanged = true;
                }
                else if (input[0] == "Insert")
                {
                    int valueToInsertAtIndex = int.Parse(input[1]);
                    int insertIndex = int.Parse(input[2]);
                    numbers.Insert(insertIndex, valueToInsertAtIndex);
                    isChanged = true;
                }
                else if (input[0] == "Contains")
                {
                    int numToSearch = int.Parse(input[1]);
                    if (numbers.Contains(numToSearch))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (input[0] == "PrintEven")
                {
                    List<int> evenList = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {

                        if (numbers[i] % 2 == 0)
                        {
                            evenList.Add(numbers[i]);
                        }

                    }
                    Console.WriteLine(String.Join(" ", evenList));
                }
                else if (input[0] == "PrintOdd")
                {
                    List<int> oddList = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {

                        if (numbers[i] % 2 != 0)
                        {
                            oddList.Add(numbers[i]);
                        }

                    }
                    Console.WriteLine(String.Join(" ", oddList));
                }
                else if (input[0] == "GetSum")
                {
                    int totalSum = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        totalSum += numbers[i];
                    }
                    Console.WriteLine(totalSum);
                }
                else if (input[0] == "Filter")
                {

                    int numToCompare = int.Parse(input[2]);
                    List<int> filteredNumbers = new List<int>();


                    if (input[1] == ">")
                    {

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > numToCompare)
                            {
                                filteredNumbers.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(String.Join(" ", filteredNumbers));

                    }
                    else if (input[1] == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < numToCompare)
                            {
                                filteredNumbers.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(String.Join(" ", filteredNumbers));
                    }
                    else if (input[1] == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= numToCompare)
                            {
                                filteredNumbers.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(String.Join(" ", filteredNumbers));
                    }
                    else if (input[1] == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= numToCompare)
                            {
                                filteredNumbers.Add(numbers[i]);
                            }
                        }

                    }
                    else
                    {
                        break;
                    }

                }

                command = Console.ReadLine();

            }

            if (isChanged)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }


        }
    }
}