using DDRScoreTracker.API.Models;
using DDRScoreTracker.API.Models.Songs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDRScoreTracker.API.Repositories
{
    public class SongRepository : ISongRepository
    {
        private readonly AppDbContext _context;

        public SongRepository (AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Song>> GetSongs() => await _context.Songs.ToListAsync();
    }
}
