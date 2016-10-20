using Microsoft.Practices.Unity;
using RotaractCoders.Domain.Contracts.Infraestructure.API.Repository;
using RotaractCoders.Infraestructure.API.Repository;

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
