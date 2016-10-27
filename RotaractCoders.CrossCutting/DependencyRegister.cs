using Microsoft.Practices.Unity;
using RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.API.Repository;
using RotaractCoders.Infraestructure.WebCroley.Repository;

namespace RotaractCoders.CrossCutting
{
    public class DependencyRegister
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<IOmirBrasilRepository, OmirBrasilRepository>(new HierarchicalLifetimeManager());
        }
    }
}
