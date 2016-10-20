using Microsoft.Practices.Unity;
using RotaractCoders.Domain.Contracts.Services;

namespace RotaractCoders.Business.Test
{
    public class TestBase
    {
        protected IWebCrowleyOmirService _webCrowleyOmirService;

        public TestBase()
        {
            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            _webCrowleyOmirService = container.Resolve<IWebCrowleyOmirService>();
        }
    }
}
