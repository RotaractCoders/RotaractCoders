using RotaractCoders.Domain.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotaractCoders.Infraestructure.Data.Map
{
    public class ProjetoMap : EntityTypeConfiguration<Project>
    {
        public ProjetoMap()
        {
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasMaxLength(300)
                .IsRequired();
        }
    }
}
