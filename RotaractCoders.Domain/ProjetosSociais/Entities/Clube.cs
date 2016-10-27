using RotaractCoders.Domain.ProjetosSociais.Scopes;
using System;

namespace RotaractCoders.Domain.ProjetosSociais.Entities
{
    public class Clube
    {
        #region Constructors

        protected Clube() { }

        public Clube(int codigo, string nome, string facebook, string email, Distrito distrito)
        {
            Id = Guid.NewGuid();
            Codigo = codigo;
            Nome = nome;
            Facebook = facebook;
            Email = email;
            Distrito = distrito;
        }

        #endregion

        #region Methods

        public Guid Id { get; private set; }

        public int Codigo { get; private set; }

        public string Nome { get; private set; }

        public string Facebook { get; private set; }

        public string Email { get; private set; }

        public Distrito Distrito { get; private set; }

        #endregion

        #region Methods

        public bool Valido() => this.ScopeIsValid();

        #endregion
    }
}