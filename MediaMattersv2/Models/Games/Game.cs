using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersv2.Models.Games
{
    public class Game
    {
        public string title { get; set; }
        public string platform { get; set; }
        public string releaseDate { get; set; }
        public string creator { get; set; }
        public int numOfPlayers { get; set; }
        public string image { get; set; }
        public string notes { get; set; }
    }
}
