using DDRScoreTracker.API.Models.Songs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDRScoreTracker.API.Repositories
{
    public interface ISongRepository
    {
        Task<List<Song>> GetSongs();
    }
}
