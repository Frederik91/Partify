using System;
using Microsoft.EntityFrameworkCore;
using Partify.Database.Tables;

namespace Partify.Database
{
    public class PartifyContext : DbContext
    {
        public DbSet<TrackTbl> Tracks { get; set; }
        public DbSet<VideoTbl> Videos { get; set; }

        public PartifyContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrackTbl>()
                .HasAlternateKey(x => x.SpotifyId);

            modelBuilder.Entity<VideoTbl>()
                .HasAlternateKey(x => x.YouTubeId);
        }
    }
}
