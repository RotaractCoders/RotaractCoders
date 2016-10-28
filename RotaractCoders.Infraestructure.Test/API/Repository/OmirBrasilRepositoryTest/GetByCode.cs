using RotaractCoders.Domain.ProjetosSociais.Entities;
using RotaractCoders.Infraestructure.WebCroley.Repository;
using RotaractCoders.Test.Common.ProjetosSociais.Mock;
using Xunit;

namespace RotaractCodigors.Infraestructure.Test.API.Repository.OmirBrasilRepositoryTest
{
    public class GetByCode
    {
        private readonly Projeto projeto;

        public GetByCode()
        {
            projeto = ProjetoMock.Projeto_10289;
        }

        [Fact]
        public void Success()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.True(result.Valido());
            }
        }

        [Fact]
        public void Success_Nome()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.Nome, result.Nome);
            }
        }

        [Fact]
        public void Success_Clube()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.Clube.Nome, result.Clube.Nome);
                Assert.Equal(projeto.Clube.Codigo, result.Clube.Codigo);
                Assert.Equal(projeto.Clube.Email, result.Clube.Email);
                Assert.Equal(projeto.Clube.Facebook, result.Clube.Facebook);
                Assert.Equal(projeto.Clube.Distrito.Numero, result.Clube.Distrito.Numero);
            }
        }

        [Fact]
        public void Success_Justificativa()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.Justificativa, result.Justificativa);
            }
        }

        [Fact]
        public void Success_ObjetivosGerais()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.ObjetivosGerais, result.ObjetivosGerais);
            }
        }

        [Fact]
        public void Success_ObjetivosEspecificos()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.ObjetivosEspecificos, result.ObjetivosEspecificos);
            }
        }

        [Fact]
        public void Success_CategoriasPrincipais()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.CategoriasPrincipais, result.CategoriasPrincipais);
            }
        }

        [Fact]
        public void Success_CategoriasSecundarias()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.CategoriasSecundarias, result.CategoriasSecundarias);
            }
        }

        [Fact]
        public void Success_DataInicio()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.DataInicio, result.DataInicio);
            }
        }

        [Fact]
        public void Success_DataFim()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.DataFim, result.DataFim);
            }
        }

        [Fact]
        public void Success_DataFinalizacao()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.DataFinalizacao, result.DataFinalizacao);
            }
        }

        [Fact]
        public void Success_RelatorioFinanceiro()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.RelatorioFinanceiro.Quantidaderegistros, result.RelatorioFinanceiro.Quantidaderegistros);

                for (int i = 0; i < result.RelatorioFinanceiro.Quantidaderegistros; i++)
                {
                    Assert.Equal(projeto.RelatorioFinanceiro[i].Descricao, result.RelatorioFinanceiro[i].Descricao);
                    Assert.Equal(projeto.RelatorioFinanceiro[i].Data, result.RelatorioFinanceiro[i].Data);
                    Assert.Equal(projeto.RelatorioFinanceiro[i].Valor, result.RelatorioFinanceiro[i].Valor);
                }
            }
        }

        [Fact]
        public void Success_Participantes()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.Participantes, result.Participantes);
            }
        }

        [Fact]
        public void Success_PublicoAlvo()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.PublicoAlvo, result.PublicoAlvo);
            }
        }

        [Fact]
        public void Success_MeiosDeDivulgacao()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.MeiosDeDivulgacao, result.MeiosDeDivulgacao);
            }
        }

        [Fact]
        public void Success_Parcerias()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.Parcerias, result.Parcerias);
            }
        }

        [Fact]
        public void Success_Cronograma()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.Cronograma.QuantidadeDeAtividades, result.Cronograma.QuantidadeDeAtividades);

                for (int i = 0; i < result.Cronograma.QuantidadeDeAtividades; i++)
                {
                    Assert.Equal(result.Cronograma[i].Data, projeto.Cronograma[i].Data);
                    Assert.Equal(result.Cronograma[i].Descricao, projeto.Cronograma[i].Descricao);
                }
            }
        }

        [Fact]
        public void Success_Descricao()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.Descricao, result.Descricao);
            }
        }

        [Fact]
        public void Success_Resultados()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.Resultados, result.Resultados);
            }
        }

        [Fact]
        public void Success_Dificuldade()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.Dificuldade, result.Dificuldade);
            }
        }

        [Fact]
        public void Success_PalavraChave()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.PalavraChave, result.PalavraChave);
            }
        }

        [Fact]
        public void Success_Resumo()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.Resumo, result.Resumo);
            }
        }

        [Fact]
        public void Success_Fotos()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.Fotos, result.Fotos);
            }
        }

        [Fact]
        public void Success_LicoesAprendidas()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.LicoesAprendidas, result.LicoesAprendidas);
            }
        }

        [Fact]
        public void Success_DataUltimaAtualizacao()
        {
            using (var omirBrasilRepository = new OmirBrasilRepository())
            {
                var result = omirBrasilRepository.GetByCode(projeto.Codigo);

                Assert.Equal(projeto.DataUltimaAtualizacao, result.DataUltimaAtualizacao);
            }
        }
    }
}