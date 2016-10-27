using RotaractCoders.Domain.ProjetosSociais.Scopes;
using System;

namespace RotaractCoders.Domain.ProjetosSociais.Entities
{
    public class Financas
    {
        #region Constructor

        public Financas(DateTime data, string descricao, decimal valor)
        {
            Id = Guid.NewGuid();
            Data = data;
            Descricao = descricao;
            Valor = valor;
        }

        #endregion

        #region Properties

        public Guid Id { get; private set; }

        public DateTime Data { get; private set; }

        public string Descricao { get; private set; }

        public decimal Valor { get; private set; }

        public Projeto Projeto { get; private set; }

        #endregion

        #region Methods

        public bool Valido() => this.ScopeIsValid();

        #endregion
    }
}
