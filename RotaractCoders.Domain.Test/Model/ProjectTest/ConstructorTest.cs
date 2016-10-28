using RotaractCoders.Test.Common.ProjetosSociais.Mock;
using Xunit;

namespace RotaractCoders.Domain.Test.Model.ProjectTest
{
    public class ConstructorTest
    {
        [Fact]
        public void Success()
        {
            Assert.True(ProjetoMock.Projeto_10289.Valido());
        }
    }
}
