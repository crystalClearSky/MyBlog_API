namespace MyAppAPI.Models.GalleryModel
{
    public class Vote
    {
        public int Id { get; set; }
        public bool UpVote { get; set; } = false;
        public int VoteById { get; set; }
    }
}