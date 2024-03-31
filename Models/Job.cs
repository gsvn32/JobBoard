namespace JobsBoard.Models
{
    public class Job
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? Company { get; set; }
        public string? Location { get; set;}
        public string? Link { get; set; }
        public int? CompinUSD { get; set; }

        public int? CompinINR { get; set; }
        public enum Type {REMOTE,ON_SITE,HYBRID }


    }
}
