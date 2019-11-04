using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CA_S00189532
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            Song song1 = new Song("music1", "artist4", 3.45, Genre.Dance);
            Song song2 = new Song("music2", "artist2", 4.45, Genre.Pop);
            Song song3 = new Song("music3", "artist3", 3.24, Genre.Other);
            Song song4 = new Song("music4", "artist4", 2.45, Genre.Rock);
            Song song5 = new Song("music5", "artist5", 5.13, Genre.Dance);

            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);
            songs.Add(song4);
            songs.Add(song5);

            Display(songs);

            songs.Sort();
            Display(songs);

            Console.WriteLine("Shuffling");
            Shuffle(songs);
            Display(songs);
        }

        public static void Display(List<Song> songs)
        {
            Console.WriteLine("{0, -15}{1, -15}{2,-15}{3,-15}", "Artist", "Song", "Duration", "Genre");
            foreach (Song song in songs)
            {
                Console.WriteLine(song);
            }
            Console.WriteLine();
        }

        private static Random rng = new Random();
        public static void Shuffle(List<Song> _songs)
        {
            int i = _songs.Count;
            while (i > 1)
            {
                i--;
                int k = rng.Next(i + 1);
                Song value = _songs[k];
                _songs[k] = _songs[i];
                _songs[i] = value;
            }
        }
    }
}
