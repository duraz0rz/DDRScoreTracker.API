using DDRScoreTracker.API.Models;
using DDRScoreTracker.API.Models.Songs;
using DDRScoreTracker.API.Repositories;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using MockQueryable.Moq;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace DDRScoreTracker.API.Tests.Repositories
{
    public class SongRepositoryTests
    {
        [Fact]
        public async Task GetSongs_RetrievesAllSongsFromContext()
        {
            var expectedSongs = new List<Song>
            {
                new Song { Name = "Hello" },
                new Song { Name = "goodbye" }
            };

            var mock = expectedSongs.AsQueryable().BuildMockDbSet();
            var mockContext = new Mock<AppDbContext>();

            mockContext.SetupGet(x => x.Songs)
                .Returns(mock.Object);

            var actualSongs = await new SongRepository(mockContext.Object).GetSongs();

            actualSongs.Should().BeEquivalentTo(expectedSongs);
        }
    }
}
