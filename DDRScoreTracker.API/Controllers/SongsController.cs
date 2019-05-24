using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DDRScoreTracker.API.Models.Songs;
using DDRScoreTracker.API.Repositories;

namespace DDRScoreTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ISongRepository _songRepository;

        public SongsController(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }

        // GET: api/Songs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Song>>> GetSongs()
        {
            return await _songRepository.GetSongs();
        }

    }
}
