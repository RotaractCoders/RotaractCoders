using RotaractCoders.Domain.Scopes;
using System;
using System.Collections.Generic;

namespace RotaractCoders.Domain.Model
{
    public class District
    {
        #region Constructors

        public District(string number)
        {
            Id = Guid.NewGuid();
            Number = number;
        }

        #endregion

        #region Methods

        public Guid Id { get; private set; }

        public string Number { get; private set; }

        public List<Club> Clubs { get; private set; }

        #endregion

        #region Methods

        public bool IsValid()
        {
            return this.ScopeIsValid();
        }

        #endregion
    }
}
