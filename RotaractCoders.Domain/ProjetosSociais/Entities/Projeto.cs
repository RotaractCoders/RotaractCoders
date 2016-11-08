using RotaractCoders.Domain.ProjetosSociais.Commands.ProjetoCommands;
using RotaractCoders.Domain.ProjetosSociais.Scopes;
using System;
using System.Collections.Generic;

namespace RotaractCoders.Domain.ProjetosSociais.Entities
{
    public class Projeto
    {
        #region Construtores

        public Projeto (NovoProjetoCommand command)
        {
            Id = Guid.NewGuid();
            Codigo = command.Codigo;
            DataUltimaAtualizacao = command.DataUltimaAtualizacao;
            Clube = command.Clube;
            Nome = command.Nome;
            Justificativa = command.Justificativa ?? string.Empty;
            ObjetivosGerais = command.ObjetivosGerais??new List<string>();
            ObjetivosEspecificos = command.ObjetivosEspecificos ?? new List<string>();
            CategoriasPrincipais = command.CategoriasPrincipais ?? new List<string>();
            CategoriasSecundarias = command.CategoriasSecundarias ?? new List<string>();
            DataInicio = command.DataInicio;
            DataFim = command.DataFim;
            DataFinalizacao = command.DataFinalizacao;
            RelatorioFinanceiro = command.RelatorioFinanceiro ?? new RelatorioFinanceiro();
            Participantes = command.Participantes ?? new List<string>();
            PublicoAlvo = command.PublicoAlvo ?? new List<string>();
            MeiosDeDivulgacao = command.MeiosDeDivulgacao ?? new List<string>();
            Parcerias = command.Parcerias ?? new List<string>();
            Cronograma = command.Cronograma ?? new Cronograma();
            Descricao = command.Descricao ?? string.Empty;
            Fotos = command.Fotos??string.Empty;
            Resultados = command.Resultados ?? string.Empty;
            Dificuldade = command.Dificuldade ?? string.Empty;
            PalavraChave = command.PalavraChave ?? string.Empty;
            LicoesAprendidas = command.LicoesAprendidas ?? string.Empty;
            Resumo = command.Resumo ?? string.Empty;
        }

        #endregion

        #region Propriedades

        public Guid Id { get; private set; }

        public int Codigo { get; private set; }

        public DateTime? DataUltimaAtualizacao { get; private set; }

        public string Nome { get; private set; }

        public string Justificativa { get; private set; }

        public List<string> ObjetivosGerais { get; private set; }

        public List<string> ObjetivosEspecificos { get; private set; }

        public List<string> CategoriasPrincipais { get; private set; }

        public List<string> CategoriasSecundarias { get; private set; }

        public DateTime? DataInicio { get; private set; }

        public DateTime? DataFim { get; private set; }

        public DateTime? DataFinalizacao { get; private set; }

        public RelatorioFinanceiro RelatorioFinanceiro { get; private set; }

        public List<string> Participantes { get; private set; }

        public List<string> PublicoAlvo { get; private set; }

        public List<string> MeiosDeDivulgacao { get; private set; }

        public List<string> Parcerias { get; private set; }

        public Cronograma Cronograma { get; private set; }

        public string Descricao { get; private set; }

        public string Fotos { get; private set; }

        public string Resultados { get; private set; }

        public string Dificuldade { get; private set; }

        public string PalavraChave { get; private set; }

        public string LicoesAprendidas { get; private set; }

        public string Resumo { get; private set; }

        public Clube Clube { get; private set; }

        #endregion

        #region Methods

        public bool Valido() => this.ScopeIsValid();

        public Projeto Atualizar(Projeto projetoAtualizado)
        {
            DataUltimaAtualizacao = projetoAtualizado.DataUltimaAtualizacao;
            Nome = projetoAtualizado.Nome;
            Justificativa = projetoAtualizado.Justificativa;
            ObjetivosGerais = projetoAtualizado.ObjetivosGerais;
            ObjetivosEspecificos = projetoAtualizado.ObjetivosEspecificos;
            CategoriasPrincipais = projetoAtualizado.CategoriasPrincipais;
            CategoriasSecundarias = projetoAtualizado.CategoriasSecundarias;
            DataInicio = projetoAtualizado.DataInicio;
            DataFim = projetoAtualizado.DataFim;
            DataFinalizacao = projetoAtualizado.DataFinalizacao;
            RelatorioFinanceiro = projetoAtualizado.RelatorioFinanceiro;
            Participantes = projetoAtualizado.Participantes;
            PublicoAlvo = projetoAtualizado.PublicoAlvo;
            MeiosDeDivulgacao = projetoAtualizado.MeiosDeDivulgacao;
            Parcerias = projetoAtualizado.Parcerias;
            Cronograma = projetoAtualizado.Cronograma;
            Descricao = projetoAtualizado.Descricao;
            Fotos = projetoAtualizado.Fotos;
            Resultados = projetoAtualizado.Resultados;
            Dificuldade = projetoAtualizado.Dificuldade;
            PalavraChave = projetoAtualizado.PalavraChave;
            LicoesAprendidas = projetoAtualizado.LicoesAprendidas;
            Resumo = projetoAtualizado.Resumo;

            return this;
        }

        #endregion
    }
}