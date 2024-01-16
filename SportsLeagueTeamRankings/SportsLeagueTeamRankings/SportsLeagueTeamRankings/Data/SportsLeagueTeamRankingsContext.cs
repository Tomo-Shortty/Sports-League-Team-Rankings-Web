using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportsLeagueTeamRankings.Models;

namespace SportsLeagueTeamRankings.Data
{
    public class SportsLeagueTeamRankingsContext : DbContext
    {
        public SportsLeagueTeamRankingsContext (DbContextOptions<SportsLeagueTeamRankingsContext> options)
            : base(options)
        {
        }

        public DbSet<SportsLeagueTeamRankings.Models.Team> Team { get; set; } = default!;
    }
}
