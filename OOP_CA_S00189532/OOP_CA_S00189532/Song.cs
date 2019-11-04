using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CA_S00189532
{
    public enum Genre
    {
        Rock,
        Pop,
        Dance,
        Other
    }

    class Song : IComparable
    {
        public string title { get; set; }
        public string artist { get; set; }
        public double duration { get; set; }
        public Genre genre { get; set; }

        public Song(string Title, string Artist, double Duration, Genre _Genre)
        {
            title = Title;
            artist = Artist;
            duration = Duration;
            genre = _Genre;
        }
        public Song(string Title, string Artist, double Duration) : this(Title, Artist, Duration, Genre.Dance)
        {

        }
        public Song() : this("","", 0)
        {

        }

        public override string ToString()
        {
            return string.Format($"{artist,-15}{title,-15}{duration,-15}{genre,-15}");
        }

        public int CompareTo(object obj)
        {
            Song that = (Song)obj;
            return this.artist.CompareTo(that.artist);
        }
    }
}
