using DDRScoreTracker.API.Controllers;
using DDRScoreTracker.API.Models.Songs;
using DDRScoreTracker.API.Repositories;
using FluentAssertions;
using Moq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xunit;

namespace DDRScoreTracker.API.Tests.Controllers
{
    public class SongsControllerTests
    {
        [Fact]
        public async Task GetSongs_DoesTheThing()
        {
            var mockSongRepository = new Mock<ISongRepository>();
            var expectedSongList = new List<Song>
            {
                new Song { Name = "Meow" },
                new Song { Name = "Rawr" }
            };

            mockSongRepository.Setup(x => x.GetSongs())
                .ReturnsAsync(expectedSongList);

            var subject = new SongsController(mockSongRepository.Object);

            var result = await subject.GetSongs();

            result.Value.Should().BeEquivalentTo(expectedSongList);
        }
    }
}
