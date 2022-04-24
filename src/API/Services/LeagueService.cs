using API.Models;

namespace API.Services
{
    public class LeagueService
    {
        private List<League> leagues = new List<League>();


        public IEnumerable<League> GetLeagues()
        {
            if (leagues.Any() == false) Seed();

            return leagues;
        }

        private void Seed()
        {
            leagues.Add(new League
            {
                Id = 1,
                Name = "Premier",
            });
            leagues.Add(new League
            {
                Id = 2,
                Name = "LaLiga",
            });
            leagues.Add(new League
            {
                Id = 3,
                Name = "LeagueOne",
            });
            leagues.Add(new League
            {
                Id = 4,
                Name = "Sierra-A",
            });
        }
    }
}
