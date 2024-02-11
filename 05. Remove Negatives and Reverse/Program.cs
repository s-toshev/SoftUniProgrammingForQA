namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> textList = text.Split().ToList();
            List<int> list = new List<int>();

            for (int i = 0; i < textList.Count; i++)
            {
                list.Add(int.Parse(textList[i]));
            }

            list.RemoveAll(x => x < 0);

            list.Reverse();

            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", list));
            }
        }
    }
}