using System.Collections.Generic;
using WebApplication3.NewFolder;

namespace WebApplication3.Data
{
    public interface IAnonymousEurosongDataList
    {
        public class AnonymousEurosongDataList : IAnonymousEurosongDataContext
        {
            List<Song> songs = new List<Song>();

            public void AddSong(Song song)
            {
                songs.Add(song);
            }

            public IEnumerable<Song> GetSongs()
            {
                return songs;
            }
        }
    }
  
    
}
