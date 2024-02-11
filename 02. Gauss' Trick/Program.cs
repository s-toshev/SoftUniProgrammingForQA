namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> listText = text.Split().ToList();
            List<int> intList = new List<int>();

            for (int i = 0; i < listText.Count; i++)
            {
                intList.Add(int.Parse(listText[i]));

            }
            List<int> resultList = new List<int>();

            if (intList.Count % 2 == 0)
            {
                for (int i = 0; i < intList.Count; i++)
                {
                    int currentPosition = intList[i];
                    int numToRemove = intList[intList.Count - 1];
                    int numToAdd = currentPosition + numToRemove;
                    resultList.Add(numToAdd);
                    intList.RemoveAt(intList.Count - 1);

                }

                Console.WriteLine(String.Join(" ", resultList));
            }
            else
            {

                for (int i = 0; i < intList.Count / 2; i++)
                {
                    int currentPosition = intList[i];
                    int numToRemove = intList[intList.Count - 1];
                    int numToAdd = currentPosition + numToRemove;
                    resultList.Add(numToAdd);
                    intList.RemoveAt(intList.Count - 1);

                }
                resultList.Add(intList[intList.Count - 1]);

                Console.WriteLine(String.Join(" ", resultList));


            }


        }
    }
}