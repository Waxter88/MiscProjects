using Microsoft.EntityFrameworkCore;
using JacksonPipe_MVC_Music.Models;
using System.Diagnostics.Metrics;
using Instrument = JacksonPipe_MVC_Music.Models.Instrument;

namespace JacksonPipe_MVC_Music.Data
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {
        }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Play> Plays { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //primary instrument for each musician
            builder.Entity<Musician>()
                .HasOne(m => m.Instrument);
            //many to many
            builder.Entity<Play>()
                .HasKey(p => new { p.InstrumentID, p.MusicianID });

            builder.Entity<Musician>()
                .HasIndex(u => u.SIN)
                .IsUnique();

            //No cascade delete from Musician to Play
            //Allow cascade delete from Instrument to Play
            builder.Entity<Play>()
                .HasOne(p => p.Instrument)
                .WithMany(m => m.Play)
                .HasForeignKey(p => p.InstrumentID)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}

