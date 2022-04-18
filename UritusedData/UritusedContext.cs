using Microsoft.EntityFrameworkCore;
using UritusedData.Models;

namespace UritusedData
{
    public class UritusedContext : DbContext
    {
        public UritusedContext(DbContextOptions options) : base(options) { }

        public DbSet<Osalejad> Osalejad { get; set; }
        public DbSet<Uritused> Uritused { get; set; }
        public DbSet<Ettevote> Ettevotted { get; set; }
    }
}
