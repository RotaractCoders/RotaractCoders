using RotaractCoders.Domain.Enums;
using RotaractCoders.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace RotaractCoders.Domain.Test.Model.ProjectTest
{
    public class ConstructorTest
    {
        [Fact]
        public void Success()
        {
            var project = new Project(
                10289,
                new Club(526, "ROTARACT CLUB PALMEIRA DAS MISSÕES", "https://www.facebook.com/rotaract.palmeira", "rctpalmeira.4660@gmail.com", new District("4660")),
                "IV Futebol Solidário",
                "Através deste projeto, buscamos incentivar a prática de esportes em crianças até 12 anos, trazendo sua devida importância e o beneficio que tem se tem para o desenvolvimento delas. Uma criança que pratica algum tipo de esporte, além de ser mais saudável, estimula aspectos psicológicos como a liderança, competividade, a superar seus limites, ter responsabilidades, a aceitar as diferenças e as dificuldades. O projeto se encontra na VI edição devido ao seu grande sucesso. Neste ano, o foco será para crianças da vila Fátima, que não possuem acesso a oportunidades como esta. Diante disso, o local escolhido para o projeto será na praça da própria vila, facilitando o acesso para as crianças e familiares que ali moram. Através deste projeto, pretendemos também arrecadas fundos para auxiliar o caixa do clube através de uma taxa de inscrição.",
                new List<string>
                {
                    "Incentivar a prática de esportes nas crianças e arrecadar recursos para projetos futuros."
                },
                new List<string>
                {
                    "Através de um torneio de futebol, incentivar crianças na faixa etária de 7 a 13 anos a praticarem esportes;",
                    "Com a taxa das inscrições, arrecadar fundos para serem investidos em projetos futuros;",
                    "Acesso a oportunidades para uma vila que não possui acesso."
                },
                new List<EnumProjectCategory>
                {
                    EnumProjectCategory.Community
                },
                new List<EnumProjectCategory>
                {
                    EnumProjectCategory.Finances
                },
                new DateTime(2016, 09, 18),
                new DateTime(2016, 10, 01),
                null,
                new List<ProjectFinancial>
                {
                    new ProjectFinancial(new DateTime(2016,09,18), "Lançamento da proposta e aprovação do projeto", 0),
                    new ProjectFinancial(new DateTime(2016,09,22), "Medalhas", 0),
                    new ProjectFinancial(new DateTime(2016,09,26), "Cachorro Quente", 0),
                    new ProjectFinancial(new DateTime(2016,09,27), "Refrigerante", 0),
                    new ProjectFinancial(new DateTime(2016,09,28), "Guardanapos, copos etc", 0)
                },
                new List<EnumParticipant>
                {
                    EnumParticipant.Rotaract,
                    EnumParticipant.Rotary,
                    EnumParticipant.OtherVoluntaries
                },
                "até 12 anos",
                new List<string>
                {
                    "Facebook",
                    "Jornal"
                },
                new List<string>
                {
                    "Secretarias de esportes"
                },
                new List<Schedule>
                {
                    new Schedule(new DateTime(2016,9,18), "Proposta lançada e aprovação do projeto"),
                    new Schedule(new DateTime(2016,9,21), "Check-list"),
                    new Schedule(new DateTime(2016,10,1), "Evento")
                },
                "Com o projeto já planejado, comidas, bebidas e medalhas já adquiridas, o evento que foi realizado na quadra de uma praça em um bairro carente da nossa cidade, tendo inicio as 13:30 com o cadastro dos times com base sub 11 e sub 13. Durante a tarde foram distribuídos cachorro quente, sacolés, pipoca e refrigerante para as crianças e no fim do campeonato, medalhas foram entregues aos vencedores. O evento teve termino as 18:00",
                "Tivemos um excelente resultado, pois através deste projeto tivemos uma maior aproximação do clube com a comunidade, além de fazer parcerias com rotarianos e a secretaria de esporte da nossa cidade. O projetos teve grandes resultados e melhorias.",
                EnumDifficulty.Easy,
                "Futebol, crianças, torneio",
                "O 4º Futebol Solidario, , teve com objetivo incentivar a prática de esportes em crianças e a arrecadação de recursos para projetos futuros. O torneio contou com a participação de cinquenta (50) crianças da nossa comunidade, que além da prática do esporte receberam lanche e premiações ao final do campeonato.");

            Assert.True(project.IsValid());
        }
    }
}
