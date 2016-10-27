using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;
using Xunit;

namespace RotaractCoders.Domain.Test.Model.ScheduleTest
{
    public class ConstructorTest
    {
        [Fact]
        public void Success()
        {
            var atividade = new Atividade(DateTime.Now, "Teste");
            Assert.True(atividade.Valido());
        }
    }
}
