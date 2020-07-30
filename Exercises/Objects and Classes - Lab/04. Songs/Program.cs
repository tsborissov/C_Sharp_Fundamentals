using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            // {typeList}_{name}_{time}

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songDetails = Console.ReadLine().Split('_').ToArray();

                songs.Add(new Song(songDetails[0], songDetails[1], songDetails[2]));
            }

            // Type List / "all"

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                Console.WriteLine(string.Join(Environment.NewLine, songs));
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, songs.Where(x => x.TypeList == typeList)));
            }

        }
    }

    public class Song
    {
        // Type List, Name and Time

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
