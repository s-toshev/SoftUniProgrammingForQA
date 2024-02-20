namespace Songs
{
    internal class Run
    {
        static void Main(string[] args)
        {

            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Songs> list = new List<Songs>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                string typeList = data[0];
                string name = data[1];
                string time = data[2];

                Songs currentSong = new(typeList, name, time);

                list.Add(currentSong);
            }

            string command = Console.ReadLine();


            if(command == "all")
            {
                foreach (Songs song in list)
                {
                    Console.WriteLine(song.GetName());
                }
            }
            else
            {
               List<Songs> filteredList = list.Where(s => s.GetTypeList() == command).ToList();

                foreach (Songs song in filteredList)
                {
                    Console.WriteLine(song.GetName());
                }
            }

        }
    }
}
