using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oroklodes
{
    internal class Movie : SZIT
    {
        public int Hour {  get; set; }
        public int Minute { get; set; }

        public Movie(string title, string creator, string genre, int hour, int minute) : base(title, creator, genre)
        {
            Hour = hour;
            Minute = minute;
        }

        public override string Write()
        {
            return $"Cím: {Title}\nÍró: {Creator}\nMűfaj: {Genre}\nJátékidő: {Hour}ó {Minute}p\n";
        }
    }
}
