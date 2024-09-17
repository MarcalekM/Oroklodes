using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    abstract class SZIT
    {
        public string Title {  get; set; }
        public string Creator {  get; set; }
        public string Genre { get; set; }

        public SZIT(string title, string creator, string genre)
        {
            Title = title;
            Creator = creator;
            Genre = genre;
        }

        public abstract string Write();
    }
}
