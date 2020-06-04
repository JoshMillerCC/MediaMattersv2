using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersv2.Models.Albums
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> getAlbums();
        Album getAlbumByTitle(string title);
    }
}
