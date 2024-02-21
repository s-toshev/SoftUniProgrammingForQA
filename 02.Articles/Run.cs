namespace _02.Articles
{
    public class Run
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Article article = new(input[0], input[1], input[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] data = Console.ReadLine().Split(": ");
                string command = data[0];
                string information = data[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(information);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(information);
                        break;

                    case "Rename":
                        article.Rename(information);
                        break;
                }
            }


            Console.WriteLine(article.ToString());

        }
    }
}
