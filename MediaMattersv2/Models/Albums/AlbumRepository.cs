using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersv2.Models.Albums
{
    public class AlbumRepository : IAlbumRepository
    {
        public Album getAlbumByTitle(string title)
        {
            return getAlbums().FirstOrDefault(p => p.title == title);
        }

        public IEnumerable<Album> getAlbums() =>
            new List<Album>
            {
                new Album{ title="Bone Palace Ballet", group="Chiodos", image="~/lib/images/Albums/BonePalaceBallet.jpg", notes="Released in 2007, this album put Chiodos on the map of the indie punk scene." },
                new Album{ title="Americana", group="The Offspring", image="~/lib/images/Albums/Americana.jpg", notes="Released in 1998, this album has some of the best songs that this band has ever written." },
                new Album{ title="The Colour and the Shape", group="Foo Fighers", image="~/lib/images/Albums/TheColourAndTheShape.jpg", notes="Released in 1997, this album has some songs that defined my childhood with how much I listened to them." },
                new Album{ title="Safe Is Just a Shadow", group="Ice Nine Kills", image="~/lib/images/Albums/SafeIsJustAShadow.jpg", notes="Released in 2010, my favorite song ever, 'The Greatest Story Ever Told' is on this album." },
                new Album{ title="Death Of A Bachelor", group="Panic! At The Disco", image="~/lib/images/Albums/DeathOfABachelor.jpg", notes="Released in 2016, this ablum took everything that was amazing from previous albums and shoved it all into one amazing hit." },
            };
    }
}
