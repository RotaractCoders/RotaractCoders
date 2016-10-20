using DomainNotificationHelper.Validation;
using RotaractCoders.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.Scopes
{
    public static class ScheduleScopes
    {
        public static bool ScopeIsValid(this Schedule schedule)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNull(schedule.Date, "A data é obrigatória"),
                    AssertionConcern.AssertNotEmpty(schedule.Description, "A descrição é obrigatória"),
                    AssertionConcern.AssertNotNull(schedule.Date, "O valor é obrigatório")
                );
        }
    }
}
