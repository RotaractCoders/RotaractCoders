using RotaractCoders.Domain.Model;
using Xunit;

namespace RotaractCoders.Domain.Test.Model.DistrictTest
{
    public class ConstructorTest
    {
        [Fact]
        public void Success()
        {
            var district = new District("4430");

            Assert.True(district.IsValid());
        }

        [Fact]
        public void Error_NumberEmpty()
        {
            var district = new District("");

            Assert.False(district.IsValid());
        }

        [Fact]
        public void Error_NumberLength3()
        {
            var district = new District("443");

            Assert.False(district.IsValid());
        }

        [Fact]
        public void Error_NumberLength5()
        {
            var district = new District("44333");

            Assert.False(district.IsValid());
        }
    }
}
