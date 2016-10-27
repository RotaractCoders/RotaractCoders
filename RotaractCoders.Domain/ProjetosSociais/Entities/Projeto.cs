using RotaractCoders.Domain.ProjetosSociais.Enums;
using RotaractCoders.Domain.ProjetosSociais.Scopes;
using System;
using System.Collections.Generic;

namespace RotaractCoders.Domain.ProjetosSociais.Entities
{
    public class Projeto
    {
        #region Construtores

        public Projeto(
            int codigo,
            Clube clube,
            string nome,
            string justificativa,
            List<string> objetivosGerais,
            List<string> objetivosEspecificos,
            List<Categoria> categoriasPrincipais,
            List<Categoria> categoriasSecundarias,
            DateTime dataInicio,
            DateTime dataFim,
            DateTime? dataFinalizacao,
            RelatorioFinanceiro relatorioFinanceiro,
            List<Participante> participantes,
            string publicoAlvo,
            List<string> meiosDeDivulgacao,
            List<string> parcerias,
            Cronograma cronograma,
            string descricao,
            string resultados,
            Dificuldade dificuldade,
            string palavraChave,
            string resumo)
        {
            Id = Guid.NewGuid();
            Codigo = codigo;
            Clube = clube;
            Nome = nome;
            Justificativa = justificativa;
            ObjetivosGerais = objetivosGerais;
            ObjetivosEspecificos = objetivosEspecificos;
            CategoriasPrincipais = categoriasPrincipais;
            CategoriasSecundarias = categoriasSecundarias;
            DataInicio = dataInicio;
            DataFim = dataFim;
            DataFinalizacao = dataFinalizacao;
            RelatorioFinanceiro = relatorioFinanceiro;
            Participantes = participantes;
            PublicoAlvo = publicoAlvo;
            MeiosDeDivulgacao = meiosDeDivulgacao;
            Parcerias = parcerias;
            Cronograma = cronograma;
            Descricao = descricao;
            Resultados = resultados;
            Dificuldade = dificuldade;
            PalavraChave = palavraChave;
            Resumo = resumo;
        }

        #endregion

        #region Propriedades

        public Guid Id { get; private set; }

        public int Codigo { get; private set; }

        public string Nome { get; private set; }

        public string Justificativa { get; private set; }

        public List<string> ObjetivosGerais { get; private set; }

        public List<string> ObjetivosEspecificos { get; private set; }

        public List<Categoria> CategoriasPrincipais { get; private set; }

        public List<Categoria> CategoriasSecundarias { get; private set; }

        public DateTime DataInicio { get; private set; }

        public DateTime DataFim { get; private set; }

        public DateTime? DataFinalizacao { get; private set; }

        public RelatorioFinanceiro RelatorioFinanceiro { get; private set; }

        public List<Participante> Participantes { get; private set; }

        public string PublicoAlvo { get; private set; }

        public List<string> MeiosDeDivulgacao { get; private set; }

        public List<string> Parcerias { get; private set; }

        public Cronograma Cronograma { get; private set; }

        public string Descricao { get; private set; }

        public string Resultados { get; private set; }

        public Dificuldade Dificuldade { get; private set; }

        public string PalavraChave { get; private set; }

        public string Resumo { get; private set; }

        public Clube Clube { get; private set; }

        #endregion

        #region Methods

        public bool Valido() => this.ScopeIsValid();

        #endregion
    }
}