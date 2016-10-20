using DomainNotificationHelper.Validation;
using RotaractCoders.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.Scopes
{
    public static class DistrictScope
    {
        public static bool ScopeIsValid(this District district)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(district.Id.ToString(), "O código é obrigatório"),
                    AssertionConcern.AssertNotEmpty(district.Number, "O número é obrigatório"),
                    AssertionConcern.AssertLength(district.Number, 4, 4, "O número do distrito deve ter 4 caracteres")
                );
        }
    }
}
