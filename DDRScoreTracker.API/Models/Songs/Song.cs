namespace DDRScoreTracker.API.Models.Songs
{
    public class Song
    {
        public int SongId { get; set; }
        public string Name { get; set; }
        public byte Rating { get; set; }
        public Difficulty Difficulty { get; set; }
    }
}
