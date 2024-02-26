using System.Collections.Generic;
using WebApplication3.NewFolder;

namespace WebApplication3.Data
{
    public interface IAnonymousEurosongDataContext
    {
        void AddSong(Song song);
        IEnumerable<Song> GetSongs();
    }

}

