using RotaractCoders.Domain.Scopes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.Model
{
    public class Schedule
    {
        #region Constructor

        public Schedule(DateTime date, string description)
        {
            Id = Guid.NewGuid();
            Date = date;
            Description = description;
        }

        #endregion

        #region Properties

        public Guid Id { get; private set; }

        public DateTime Date { get; private set; }

        public string Description { get; private set; }

        #endregion

        #region Methods

        public bool IsValid()
        {
            return this.ScopeIsValid();
        }

        #endregion
    }
}
