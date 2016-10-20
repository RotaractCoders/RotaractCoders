using Microsoft.Practices.Unity;
using RotaractCoders.Business.Services;
using RotaractCoders.Domain.Contracts.Repository;
using RotaractCoders.Domain.Contracts.Services;
using RotaractCoders.Infraestructure.Data;
using RotaractCoders.Infraestructure.Repositories;

namespace RotaractCoders.Startup
{
    public class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<AppDataContext, AppDataContext>(new HierarchicalLifetimeManager());

            #region Repository

            container.RegisterType<IProjetoRepository, ProjetoRepository>(new HierarchicalLifetimeManager());

            #endregion

            #region Service

            container.RegisterType<IWebCrowleyOmirService, WebCrowleyOmirService>(new HierarchicalLifetimeManager());

            #endregion
        }
    }
}
