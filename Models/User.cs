namespace llm_integrated.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Interest> Interests { get; set; }
        public ICollection<Opinion> Opinions { get; set; }
    }
}