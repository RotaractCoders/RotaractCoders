using RotaractCoders.Domain.ProjetosSociais.Commands.ProjetoCommands;
using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;
using System.Collections.Generic;

namespace RotaractCoders.Test.Common.ProjetosSociais.Mock
{
    public class ProjetoMock
    {
        public static Projeto Projeto_10289 => new Projeto(
            new NovoProjetoCommand
            {
                Codigo = 10289,
                DataUltimaAtualizacao = Convert.ToDateTime("03/10/2016 11:10:41"),
                Clube = new Clube(526, "ROTARACT CLUB PALMEIRA DAS MISSÕES", new Distrito("4660")),
                Nome = "IV Futebol Solidário",
                Justificativa = "Através deste projeto, buscamos incentivar a prática de esportes em crianças até 12 anos, trazendo sua devida importância e o beneficio que tem se tem para o desenvolvimento delas. Uma criança que pratica algum tipo de esporte, além de ser mais saudável, estimula aspectos psicológicos como a liderança, competividade, a superar seus limites, ter responsabilidades, a aceitar as diferenças e as dificuldades. O projeto se encontra na VI edição devido ao seu grande sucesso. Neste ano, o foco será para crianças da vila Fátima, que não possuem acesso a oportunidades como esta. Diante disso, o local escolhido para o projeto será na praça da própria vila, facilitando o acesso para as crianças e familiares que ali moram. Através deste projeto, pretendemos também arrecadas fundos para auxiliar o caixa do clube através de uma taxa de inscrição.",
                ObjetivosGerais = new List<string>
                {
                    "Incentivar a prática de esportes nas crianças e arrecadar recursos para projetos futuros."
                },
                ObjetivosEspecificos = new List<string>
                {
                    "Através de um torneio de futebol, incentivar crianças na faixa etária de 7 a 13 anos a praticarem esportes;",
                    "Com a taxa das inscrições, arrecadar fundos para serem investidos em projetos futuros;",
                    "Acesso a oportunidades para uma vila que não possui acesso."
                },
                CategoriasPrincipais = new List<string>
                {
                    "Comunidade"
                },
                CategoriasSecundarias = new List<string>
                {
                    "Finanças"
                },
                DataInicio = new DateTime(2016, 09, 18),
                DataFim = new DateTime(2016, 10, 01),
                DataFinalizacao = null,
                RelatorioFinanceiro = new RelatorioFinanceiro
                {
                    new Financas(new DateTime(2016,9,18), "Lançamento da proposta e aprovação do projeto", 0),
                    new Financas(new DateTime(2016,9,22), "Medalhas", 0),
                    new Financas(new DateTime(2016,9,26), "Cachorro Quente", 0),
                    new Financas(new DateTime(2016,9,27), "Refrigerante", 0),
                    new Financas(new DateTime(2016,10,28), "Guardanapos, copos etc", 0)
                },
                Participantes = new List<string>
                {
                    "Rotaractianos",
                    "Rotarianos",
                    "Voluntários Adicionais"
                },
                PublicoAlvo = new List<string>
                {
                    "até 12 anos"
                },
                MeiosDeDivulgacao = new List<string>
                {
                    "Facebook",
                    "Jornal"
                },
                Parcerias = new List<string>
                {
                    "Secretarias de esportes"
                },
                Cronograma = new Cronograma
                {
                    new Atividade(new DateTime(2016,9,18), "Proposta lançada e aprovação do projeto"),
                    new Atividade(new DateTime(2016,9,21), "Check-list"),
                    new Atividade(new DateTime(2016,10,1), "Evento")
                },
                Descricao = "Com o projeto já planejado, comidas, bebidas e medalhas já adquiridas, o evento que foi realizado na quadra de uma praça em um bairro carente da nossa cidade, tendo inicio as 13:30 com o cadastro dos times com base sub 11 e sub 13. Durante a tarde foram distribuídos cachorro quente, sacolés, pipoca e refrigerante para as crianças e no fim do campeonato, medalhas foram entregues aos vencedores. O evento teve termino as 18:00",
                Resultados = "Tivemos um excelente resultado, pois através deste projeto tivemos uma maior aproximação do clube com a comunidade, além de fazer parcerias com rotarianos e a secretaria de esporte da nossa cidade. O projetos teve grandes resultados e melhorias.",
                Dificuldade = "Baixa",
                PalavraChave = "Futebol, crianças, torneio",
                Resumo = "O 4º Futebol Solidario, , teve com objetivo incentivar a prática de esportes em crianças e a arrecadação de recursos para projetos futuros. O torneio contou com a participação de cinquenta (50) crianças da nossa comunidade, que além da prática do esporte receberam lanche e premiações ao final do campeonato."
            });

        public static Projeto Projeto_10111 => new Projeto(
            new NovoProjetoCommand
            {
                Codigo = 10111,
                DataUltimaAtualizacao = Convert.ToDateTime("02/09/2016 18:09:32"),
                Clube = new Clube(14, "ROTARACT CLUB UBÁ ARY BARROSO", new Distrito("4580")),
                Nome = "Hepatite Zero",
                Justificativa = "Erradicar a Hepatite do mundo",
                ObjetivosGerais = new List<string>
                {
                    "Auxiliar ao Rotary Ubá a identificar os casos de Hepatite B e C na cidade de Ubá - MG."
                },
                ObjetivosEspecificos = new List<string>
                {
                    "O Rotaract Club Ubá - Ary Barroso objetivava auxiliar o Rotary Club Ubá a indentificar os casos de Hepatites B e C na cidade de Ubá - MG. Durante o projeto os Rotaractianos ajudaram a divulgar o local onde estava se realizando os exames gratuitos, assistiram os enfermeiros que estavam realizando os exames e organizaram as fichas de todos os pacientes."
                },
                CategoriasPrincipais = new List<string>
                {
                    "Comunidade"
                },
                CategoriasSecundarias = new List<string>
                {
                    "Internacionais"
                },
                DataInicio = new DateTime(2016,09,23),
                DataFim = new DateTime(2016, 09, 23),
                DataFinalizacao = new DateTime(2016, 09, 02),
                RelatorioFinanceiro = new RelatorioFinanceiro(),
                Participantes = new List<string>
                {
                    "Interactianos",
                    "Rotaractianos"
                },
                PublicoAlvo = new List<string>
                {
                    "até 12 anos",
                    "de 13 a 18 anos",
                    "de 19 a 30 anos",
                    "de 31 a 50 anos",
                    "de 51 a 65 anos",
                    "mais de 66 anos"
                },
                MeiosDeDivulgacao = new List<string>
                {
                    "Panfletagem e facebook"
                },
                Cronograma = new Cronograma(),
                Descricao = "Durante o projeto foram realizados exames para indentificar casos de hepatite B e C entre a população de Ubá - MG. O projeto ocorreu no Calçadão Imbrahim Jacob. Felizmente, poucos casos foram identificados.",
                Fotos = "https://www.facebook.com/permalink.php?story_fbid=1668391750150582&id=100009393187283&pnref=story",
                Resultados = "Felizmente poucos casos foram identificados em meio a um contingente consideravelmente alto, ou seja, em nossa cidade há poucos casos de Hepatites. Outro ponto positivo foi o fato de termos atendido os mais variados tipos de pessoas, nas mais variadas faixas etarias e raças. De fato o projeto foi muito bem sucedido.",
                Dificuldade = "Baixa",
                PalavraChave = "hepatite zero; Rotary; Ubá; 4580;",
                LicoesAprendidas = "O companheirismo e a integração entre Rotarys, Rotaracts e Interacts devem perseverar em prol de toda a sociedade.",
                Resumo = "O Rotaract Club Ubá - Ary Barroso auxiliou o Rotary Ubá a indenficar os casos de Hepatite em Ubá assistindo organizando as filas, divulgando o projetos e auxiliando os enfermeiros a realizarem os exames."
            });
    }
}
