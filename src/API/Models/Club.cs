namespace API.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual League League { get; set; } = new League();
    }
}
