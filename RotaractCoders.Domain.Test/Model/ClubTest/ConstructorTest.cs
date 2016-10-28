using RotaractCoders.Domain.ProjetosSociais.Entities;
using Xunit;

namespace RotaractCoders.Domain.Test.Model.ClubTest
{
    public class ConstructorTest
    {
        [Fact]
        public void Success()
        {
            var distrito = new Distrito("4430");
            var clube = new Clube(526, "ROTARACT CLUB PALMEIRA DAS MISSÕES", distrito);

            Assert.True(clube.Valido());
        }
    }
}
