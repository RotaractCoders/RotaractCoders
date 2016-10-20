using RotaractCoders.Domain.Model;
using Xunit;

namespace RotaractCoders.Business.Test.Service.WebCrowleyOmirServiceTest
{
    public class BuscarProjetoTest : TestBase
    {
        [Fact]
        public void Success()
        {
            var projetoComparar = new Projeto("Tremembé", "4430", "Rotamira");
            var projeto = _webCrowleyOmirService.BuscarProjeto(100);

            Assert.Equal(projetoComparar.Nome, projeto.Nome);
        }
    }
}