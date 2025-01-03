namespace llm_integrated.Models
{
    public class Recommendation
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}