using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Song.ReadInput();
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split('_');

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song newSong = new Song();

                newSong.TypeList = type;
                newSong.NameSong = name;
                newSong.Time = time;

                songs.Add(newSong);
            }

            string typeSong = Console.ReadLine();

            if (typeSong == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.NameSong);
                }
            }

            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeSong)
                    {
                        Console.WriteLine(song.NameSong);
                    }
                }
            }
        }
    }

    public class Song
    {
        public string TypeList { get; set; }
        public string NameSong { get; set; }
        public string Time { get; set; }

        public static int ReadInput()
        {
            int n = int.Parse(Console.ReadLine());

            return n;
        }
    }
}
