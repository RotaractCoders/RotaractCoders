using RotaractCoders.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace RotaractCoders.Domain.Test.Model.ScheduleTest
{
    public class ConstructorTest
    {
        [Fact]
        public void Success()
        {
            var shadule = new Schedule(DateTime.Now, "Teste");
            Assert.True(shadule.IsValid());
        }
    }
}
