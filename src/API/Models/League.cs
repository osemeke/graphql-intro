namespace API.Models
{
    public class League
    {
        public League()
        {
            Clubs = new List<Club>();
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Club> Clubs { get; set; }
    }
}
