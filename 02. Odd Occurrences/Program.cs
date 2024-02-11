namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> wordsList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> lowerCaseWords = new List<string>();

            foreach (string word in wordsList)
            {
                lowerCaseWords.Add(word.ToLower());
            }

            Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();

            foreach (string word in lowerCaseWords)
            {

                if (wordsDictionary.ContainsKey(word))
                {
                    wordsDictionary[word] += 1;
                }
                else
                {
                    wordsDictionary.Add(word, 1);
                }
            }


            foreach (var item in wordsDictionary)
            {


                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }


            }

        }
    }
}