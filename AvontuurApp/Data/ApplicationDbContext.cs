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
    }
}
