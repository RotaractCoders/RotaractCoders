using Microsoft.Practices.Unity;
using RotaractCoders.ApplicationService.ProjetosSociais.Applications;
using RotaractCoders.Domain.ProjetosSociais.Contracts.Application;
using RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.Data.Repository;
using RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.WebCrowley;
using RotaractCoders.Infraestructure.Data;
using RotaractCoders.Infraestructure.Data.Repository;
using RotaractCoders.Infraestructure.WebCroley.Repository;

namespace RotaractCoders.CrossCutting
{
    public class DependencyRegister
    {
        public static void Register(UnityContainer container, string connectionString, string dataBase)
        {
            //var context = new AppDataContext("mongodb://localhost:27017", "Rotaract");
            var context = new AppDataContext(connectionString, dataBase);

            container.RegisterInstance(context);

            container.RegisterType<IProjetoRepository, ProjetoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IClubeRepository, ClubeRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IDistritoRepository, DistritoRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IOmirBrasilRepository, OmirBrasilRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IOmirBrasilApplication, OmirBrasilApplication>(new HierarchicalLifetimeManager());
        }
    }
}
