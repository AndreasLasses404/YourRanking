using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourRanking.Models;

namespace YourRanking.Data
{
    public class YourRankingContext : IdentityDbContext<User>
    {
        public YourRankingContext(DbContextOptions<YourRankingContext> options) : base(options)
        {

        }

        public DbSet<Arena> Arenas { get; set; }
        public DbSet<Match> Matches { get; set; }
    }
}
