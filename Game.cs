using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_DeBord_Joshua
{
    internal class Game
    {

        public string title { get; } 

        public char Esrb { get; }

        public string Genre { get; }

        public Game(string titleParam, char esrbParam, string genreParam)
        {
            title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }
    }
}
