using AvontuurApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AvontuurApp.Data
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<AvontuurEntry> AvontuurEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AvontuurEntry>().HasData(
                new AvontuurEntry { 
                    Id = 1, 
                    Title = "Eerste overland kamp", 
                    Content = "1ste kamp met die nuwe 4x4 by 3 berge.", 
                    Location = "3 Berge kamp", 
                    CreatedAt = DateTime.Now 
                },
                new AvontuurEntry { 
                    Id = 2, Title = "Eerste 4x4", 
                    Content = "1ste 4x4 trippie.", 
                    Location = "Pilansberg", 
                    CreatedAt = DateTime.Now 
                },
                 new AvontuurEntry
                 {
                     Id = 3,
                     Title = "Uitkyk",
                     Content = "Caos, grade 4 trail",
                     Location = "3 Berge",
                     CreatedAt = DateTime.Now
                 }
                );

        }
    }
}
