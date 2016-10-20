using AngleSharp;
using RotaractCoders.Domain.Contracts.Infraestructure.API.Repository;
using RotaractCoders.Domain.Model;
using System;
using System.Linq;

namespace RotaractCoders.Infraestructure.API.Repository
{
    public class OmirBrasilRepository : IOmirBrasilRepository
    {
        private IConfiguration config;

        public OmirBrasilRepository()
        {
            config = Configuration.Default.WithDefaultLoader();
        }

        public Project GetByCode(int code)
        {
            var omirBrasilUrl = $"http://projetos.omirbrasil.org.br/exibe_projetos.php?ID_PROJETO={code}";

            var address = "https://en.wikipedia.org/wiki/List_of_The_Big_Bang_Theory_episodes";

            var document = BrowsingContext.New(config).OpenAsync(address).Result;
            var cellSelector = "tr.vevent td:nth-child(3)";

            var cells = document.QuerySelectorAll(cellSelector);

            var titles = cells.Select(m => m.TextContent);

            throw new NotImplementedException();
        }

        public void Dispose()
        {
            config = null;
        }
    }
}
