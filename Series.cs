using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    internal class Series : SZIT
    {
        public int Epidoses {  get; set; }

        public Series(string title, string creator, string genre, int episodes) : base(title, creator, genre)
        {
            Epidoses = episodes;
        }

        public override string Write()
        {
            return $"Cím: {Title}\nÍró: {Creator}\nMűfaj: {Genre}\nEpizódok száma: {Epidoses}\n";
        }
    }
}
