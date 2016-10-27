using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;
using Xunit;

namespace RotaractCoders.Domain.Test.Model.ProjectFinancialTest
{
    public class ConstructorTest
    {
        [Fact]
        public void Success()
        {
            var projectFinancial = new Financas(DateTime.Now, "teste", 6.98m);
            Assert.True(projectFinancial.Valido());
        }

        [Fact]
        public void Error_Descricao_Em_Branco()
        {
            var projectFinancial = new Financas(DateTime.Now, "", 6.98m);
            Assert.False(projectFinancial.Valido());
        }
    }
}
