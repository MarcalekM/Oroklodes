using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    internal class Book : SZIT
    {
        public int Pages {  get; set; }

        public Book(string title, string creator, string genre,  int pages) : base(title, creator, genre)
        {
            Pages = pages;
        }

        public override string Write()
        {
            return $"Cím: {Title}\nÍró: {Creator}\nMűfaj: {Genre}\nOldaszám: {Pages}\n";
        }
    }
}
