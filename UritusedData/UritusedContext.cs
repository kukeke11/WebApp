using Microsoft.EntityFrameworkCore;
using UritusedData.Models;

namespace UritusedData
{
    //sessiooni andmebaas mille abil saab teha CRUD operatsioone
    public class UritusedContext : DbContext
    {
        //Andmebaas
        public UritusedContext(DbContextOptions options) : base(options) { }


        //Andmebaasi tabelid
        public DbSet<Osalejad> Osalejad { get; set; }
        public DbSet<Uritused> Uritused { get; set; }
        public DbSet<Ettevote> Ettevotted { get; set; }
    }
}
