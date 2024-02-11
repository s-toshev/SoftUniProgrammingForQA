namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Song> songList = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string typeList = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song(typeList, name, time);

                songList.Add(song);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (Song item in songList)
                {
                    Console.WriteLine($"{item.Name}");
                }
            }
            else
            {
                songList = songList.Where(song => song.TypeList == command).ToList();

                foreach (Song item in songList)
                {
                    Console.WriteLine($"{item.Name}");

                }
            }



        }
    }

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }

        public string Time { get; set; }

        public Song(string typeList, string name, string time)
        {

            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;

        }
    }

}