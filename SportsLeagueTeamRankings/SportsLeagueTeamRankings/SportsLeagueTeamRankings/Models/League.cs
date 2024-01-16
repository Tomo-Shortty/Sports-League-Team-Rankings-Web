using System.ComponentModel.DataAnnotations;

namespace SportsLeagueTeamRankings.Models
{
    public class League
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
