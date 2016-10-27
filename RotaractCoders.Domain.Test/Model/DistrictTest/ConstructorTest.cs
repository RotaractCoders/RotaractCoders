using RotaractCoders.Domain.ProjetosSociais.Entities;
using Xunit;

namespace RotaractCoders.Domain.Test.Model.distritoTest
{
    public class ConstructorTest
    {
        [Fact]
        public void Success()
        {
            var distrito = new Distrito("4430");

            Assert.True(distrito.Valido());
        }

        [Fact]
        public void Error_NumberEmpty()
        {
            var distrito = new Distrito("");

            Assert.False(distrito.Valido());
        }

        [Fact]
        public void Error_NumberLength3()
        {
            var distrito = new Distrito("443");

            Assert.False(distrito.Valido());
        }

        [Fact]
        public void Error_NumberLength5()
        {
            var distrito = new Distrito("44333");

            Assert.False(distrito.Valido());
        }
    }
}
