using RotaractCoders.Domain.Model;
using RotaractCoders.Infraestructure.Data.Map;
using System.Data.Entity;

namespace RotaractCoders.Infraestructure.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
            : base ("SqlConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Project> Projetos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProjetoMap());
        }
    }
}
