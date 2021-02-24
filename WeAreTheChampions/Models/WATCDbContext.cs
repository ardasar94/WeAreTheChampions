using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    public class WATCDbContext : DbContext
    {
        public WATCDbContext() : base("name = WATCData")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamColor>().HasKey(k => new { k.TeamId, k.ColorId });
            modelBuilder.Entity<Match>()
                        .HasRequired(m => m.Team1)
                        .WithMany(t => t.Team1Matches)
                        .HasForeignKey(m => m.Team1Id)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Match>()
                        .HasRequired(m => m.Team2)
                        .WithMany(t => t.Team2Matches)
                        .HasForeignKey(m => m.Team2Id)
                        .WillCascadeOnDelete(false);
        }

        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<TeamColor> TeamColors { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<Color> Colors { get; set; }

    }
}
