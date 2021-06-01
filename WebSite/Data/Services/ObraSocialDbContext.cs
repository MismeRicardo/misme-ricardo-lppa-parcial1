using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebSite.Entities.Models;

namespace WebSite.Data.Services
{
    public class ObraSocialDbContext: DbContext
    {
        public ObraSocialDbContext() : base(nameOrConnectionString: "ObraSocialConnection") { }
        public DbSet<Afiliado> Afiliados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}