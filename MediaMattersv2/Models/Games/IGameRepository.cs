using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersv2.Models.Games
{
    public interface IGameRepository
    {
        IEnumerable<Game> getGames();
        Game getGameByTitle(string title);
    }
}
