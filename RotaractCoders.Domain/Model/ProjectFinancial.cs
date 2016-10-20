using RotaractCoders.Domain.Scopes;
using System;

namespace RotaractCoders.Domain.Model
{
    public class ProjectFinancial
    {
        #region Constructor

        public ProjectFinancial(DateTime date, string description, decimal value)
        {
            Id = Guid.NewGuid();
            Date = date;
            Description = description;
            Value = value;
        }

        #endregion

        #region Properties

        public Guid Id { get; private set; }

        public DateTime Date { get; private set; }

        public string Description { get; private set; }

        public decimal Value { get; private set; }

        public Project Project { get; private set; }

        #endregion

        #region Methods

        public bool IsValid()
        {
            return this.ScopeIsValid();
        }

        #endregion
    }
}
