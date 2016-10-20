using DomainNotificationHelper.Validation;
using RotaractCoders.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.Scopes
{
    public static class ProjectFinancialScope
    {
        public static bool ScopeIsValid(this ProjectFinancial projectFinancial)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNull(projectFinancial.Date, "A data é obrigatória"),
                    AssertionConcern.AssertNotEmpty(projectFinancial.Description, "A descrição é obrigatória"),
                    AssertionConcern.AssertNotNull(projectFinancial.Value, "O valor é obrigatório")
                );
        }
    }
}
