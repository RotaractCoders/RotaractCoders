using RotaractCoders.Domain.ProjetosSociais.Scopes;
using System;

namespace RotaractCoders.Domain.ProjetosSociais.Entities
{
    public class Atividade
    {
        #region Constructor

        public Atividade(DateTime data, string descricao)
        {
            Id = Guid.NewGuid();
            Data = data;
            Descricao = descricao;
        }

        #endregion

        #region Properties

        public Guid Id { get; private set; }

        public DateTime Data { get; private set; }

        public string Descricao { get; private set; }

        #endregion

        #region Methods

        public bool Valido() => this.ScopeIsValid();

        #endregion
    }
}
