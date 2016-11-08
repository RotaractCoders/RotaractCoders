using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.ProjetosSociais.Commands.ProjetoCommands
{
    public class NovoProjetoCommand
    {
        public NovoProjetoCommand()
        {

        }

        public int Codigo { get; set; }

        public DateTime? DataUltimaAtualizacao { get; set; }

        public string Nome { get; set; }

        public string Justificativa { get; set; }

        public List<string> ObjetivosGerais { get; set; }

        public List<string> ObjetivosEspecificos { get; set; }

        public List<string> CategoriasPrincipais { get; set; }

        public List<string> CategoriasSecundarias { get; set; }

        public DateTime? DataInicio { get; set; }

        public DateTime? DataFim { get; set; }

        public DateTime? DataFinalizacao { get; set; }

        public RelatorioFinanceiro RelatorioFinanceiro { get; set; }

        public List<string> Participantes { get; set; }

        public List<string> PublicoAlvo { get; set; }

        public List<string> MeiosDeDivulgacao { get; set; }

        public List<string> Parcerias { get; set; }

        public Cronograma Cronograma { get; set; }

        public string Descricao { get; set; }

        public string Fotos { get; set; }

        public string Resultados { get; set; }

        public string Dificuldade { get; set; }

        public string PalavraChave { get; set; }

        public string LicoesAprendidas { get; set; }

        public string Resumo { get; set; }

        public Clube Clube { get; set; }
    }
}