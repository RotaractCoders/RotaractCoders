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
            var clube = new Clube(526, "ROTARACT CLUB PALMEIRA DAS MISSÕES", "https://www.facebook.com/rotaract.palmeira", "rctpalmeira.4660@gmail.com", distrito);

            Assert.True(clube.Valido());
        }


        [Fact]
        public void Error_CodeZero()
        {
            var distrito = new Distrito("4430");
            var clube = new Clube(0, "ROTARACT CLUB PALMEIRA DAS MISSÕES", "https://www.facebook.com/rotaract.palmeira", "rctpalmeira.4660@gmail.com", distrito);

            Assert.False(clube.Valido());
        }

        [Fact]
        public void Error_DistrictInvalid()
        {
            var distrito = new Distrito("443");
            var clube = new Clube(526, "ROTARACT CLUB PALMEIRA DAS MISSÕES", "https://www.facebook.com/rotaract.palmeira", "rctpalmeira.4660@gmail.com", distrito);

            Assert.False(clube.Valido());
        }

        [Fact]
        public void Error_NameEmpty()
        {
            var distrito = new Distrito("4430");
            var clube = new Clube(526, "", "https://www.facebook.com/rotaract.palmeira", "rctpalmeira.4660@gmail.com", distrito);

            Assert.False(clube.Valido());
        }
    }
}
