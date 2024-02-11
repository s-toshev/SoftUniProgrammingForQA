namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();

            List<string> strList1 = text1.Split().ToList();
            List<string> strList2 = text2.Split().ToList();
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 0; i < strList1.Count; i++)
            {
                list1.Add(int.Parse(strList1[i]));
            }
            for (int i = 0; i < strList2.Count; i++)
            {
                list2.Add(int.Parse(strList2[i]));
            }

            List<int> resultList = new List<int>();

            if (list1.Count == list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    resultList.Add(list1[i]);
                    resultList.Add(list2[i]);
                }
                Console.WriteLine(String.Join(" ", resultList));

            }
            else
            {
                if (list1.Count < list2.Count)
                {

                    for (int i = 0; i < list1.Count; i++)
                    {
                        resultList.Add(list1[i]);
                        resultList.Add(list2[i]);
                    }

                    for (int i = list1.Count; i < list2.Count; i++)
                    {
                        resultList.Add(list2[i]);
                    }
                }
                else if (list2.Count < list1.Count)
                {

                    for (int i = 0; i < list2.Count; i++)
                    {
                        resultList.Add(list1[i]);
                        resultList.Add(list2[i]);
                    }

                    for (int i = list2.Count; i < list1.Count; i++)
                    {
                        resultList.Add(list1[i]);
                    }
                }

                Console.WriteLine(String.Join(" ", resultList));
            }


        }
    }
}