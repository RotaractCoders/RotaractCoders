using RotaractCoders.Domain.ProjetosSociais.Scopes;
using System;
using System.Collections.Generic;

namespace RotaractCoders.Domain.ProjetosSociais.Entities
{
    public class Distrito
    {
        #region Constructors

        protected Distrito()
        {

        }

        public Distrito(string numero)
        {
            Id = Guid.NewGuid();
            Numero = numero;
        }

        #endregion

        #region Methods

        public Guid Id { get; private set; }

        public string Numero { get; private set; }

        public Clubes Clubes { get; private set; }

        #endregion

        #region Methods

        public bool Valido() => this.ScopeIsValid();

        #endregion
    }
}
