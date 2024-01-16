using System.ComponentModel.DataAnnotations;

namespace SportsLeagueTeamRankings.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string League { get; set; }
    }
}
