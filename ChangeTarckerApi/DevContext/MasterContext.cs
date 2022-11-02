using ChangeTarckerApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChangeTarckerApi.DevContext
{
    public class MasterContext : DbContext
    {
        public DbSet<Developer> Developers {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("Server=localhost;Database=changetrackerdb;Uid=root;Pwd=root;");
        }
    }
}
