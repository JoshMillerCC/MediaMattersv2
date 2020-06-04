using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersv2.Models.Games
{
    public class GameRepository : IGameRepository
    {
        public Game getGameByTitle(string title)
        {
            return getGames().FirstOrDefault(p => p.title == title);
        }

        public IEnumerable<Game> getGames() =>
            new List<Game>
            {
                new Game{ title="The Last Of Us", platform="PlayStation", releaseDate="June 14, 2013", creator="Naughty Dog", numOfPlayers=1, image="~/lib/images/Games/TheLastOfUs.jpg", notes="A game that defined an entire generation of video games, at the end of the PlayStation 3's life cycle. This game had not only one of the most amazing stories I've ever played through, but amazing graphics and gripping moments to get you through the entire thing." },
                new Game{ title="Clank!", platform="Boardgame", releaseDate="October 12, 2016", creator="Renegade", numOfPlayers=4, image="~/lib/images/Games/Clank.jpg", notes="Deck building has always been one of my favorite boardgame types, and this game turns the idea of deck building over it's head by making you dive through a dungeon to get treasure at the same time." },
                new Game{ title="Ratchet & Clank: Up Your Arsenal", platform="Playstation", releaseDate="November 3, 2004", creator="Insomniac", numOfPlayers=1, image="~/lib/images/Games/RatchetAndClank.jpg", notes="Buying this game as a 14 year old changed my life in ways I didn't know it could. I was never huge into video games until I got this game and ever since, games of all types have been a huge part of my life." },
                new Game{ title="Kingdom Hearts 2", platform="PlayStation", releaseDate="December 22, 2005", creator="Square Enix", numOfPlayers=1, image="~/lib/images/Games/KingdomHearts2.jpg", notes="A game about a boy, Sora, Donald Duck, and Goofy, flying between different Disney worlds to save various Disney princesses from turning into Heartless so that Sora can find his long lost friend. It sounds like a game I would have hated but it turned out to be on the best games I think has ever been made." },
                new Game{ title="Destiny", platform="PlayStation, XBox", releaseDate="September 9, 2014", creator="Bungie", numOfPlayers=3, image="~/lib/images/Games/Destiny.jpg", notes="While the game has declined over the past few years, this is the game I've probably put the most hours into over my life except maybe League Of Legends. This is a first person shooter that I've made some of my best friends (across the country) playing and it is a game I'll never forget." },
            };

    }
}
