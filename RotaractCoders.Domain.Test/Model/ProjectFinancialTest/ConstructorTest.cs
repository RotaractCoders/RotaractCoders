using RotaractCoders.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace RotaractCoders.Domain.Test.Model.ProjectFinancialTest
{
    public class ConstructorTest
    {
        [Fact]
        public void Success()
        {
            var projectFinancial = new ProjectFinancial(DateTime.Now, "teste", 6.98m);
            Assert.True(projectFinancial.IsValid());
        }

        [Fact]
        public void Error_DescriptionEmpty()
        {
            var projectFinancial = new ProjectFinancial(DateTime.Now, "", 6.98m);
            Assert.False(projectFinancial.IsValid());
        }
    }
}
