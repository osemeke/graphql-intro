using API.Models;
using API.Services;

namespace API.GraphQL
{
    public class Query
    {
        public string Test() => "Working Ok";

        public IQueryable<League> GetLeagues()
        {
            return (new LeagueService()).GetLeagues().AsQueryable();
        }
    }
}
