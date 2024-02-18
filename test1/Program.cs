
using System.Text;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<string, string> kvp = new Dictionary<string, string>();

            //kvp.Add("ivan", "0885532542");
            //kvp.Add("petur", "0893423243");


            //foreach(var item in kvp)
            //{
            //    Console.WriteLine($"{item.Key} -->>> {item.Value}");
            //}

            string[] startingTexts = Console.ReadLine().Split(" ").Select(startingTextsItem => startingTextsItem.ToLower()).ToArray();

            List<string> result = [.. startingTexts];


            var result1 = result.Where(result => result.Length > 5).ToList();

            foreach (var item in result1)
            {
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.Append(item + " ");

                Console.Write(stringBuilder.ToString());
                Console.WriteLine();
            }


            ///Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToList().ForEach(Console.WriteLine);



            int[] startingArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] newArr = startingArr.Where(startingArrItem => startingArrItem > 34).ToArray();

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }


        }
    }
}
