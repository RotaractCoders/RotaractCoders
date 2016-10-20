using RotaractCoders.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace RotaractCoders.Domain.Test.Model.ClubTest
{
    public class ConstructorTest
    {
        [Fact]
        public void Success()
        {
            var district = new District("4430");
            var club = new Club(526, "ROTARACT CLUB PALMEIRA DAS MISSÕES", "https://www.facebook.com/rotaract.palmeira", "rctpalmeira.4660@gmail.com", district);

            Assert.True(club.IsValid());
        }


        [Fact]
        public void Error_CodeZero()
        {
            var district = new District("4430");
            var club = new Club(0, "ROTARACT CLUB PALMEIRA DAS MISSÕES", "https://www.facebook.com/rotaract.palmeira", "rctpalmeira.4660@gmail.com", district);

            Assert.False(club.IsValid());
        }

        [Fact]
        public void Error_DistrictInvalid()
        {
            var district = new District("443");
            var club = new Club(526, "ROTARACT CLUB PALMEIRA DAS MISSÕES", "https://www.facebook.com/rotaract.palmeira", "rctpalmeira.4660@gmail.com", district);

            Assert.False(club.IsValid());
        }

        [Fact]
        public void Error_NameEmpty()
        {
            var district = new District("4430");
            var club = new Club(526, "", "https://www.facebook.com/rotaract.palmeira", "rctpalmeira.4660@gmail.com", district);

            Assert.False(club.IsValid());
        }
    }
}
