using DomainNotificationHelper.Validation;
using RotaractCoders.Domain.Model;

namespace RotaractCoders.Domain.Scopes
{
    public static class ClubScope
    {
        public static bool ScopeIsValid(this Club club)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(club.Id.ToString(), "O id é obrigatório"),
                    AssertionConcern.AssertTrue(club.Code > 0, "O código é obrigatório"),
                    AssertionConcern.AssertNotEmpty(club.Name, "O nome do clube é obrigatório"),
                    AssertionConcern.AssertNotNull(club.District, "O distrito é obrigatório"),
                    AssertionConcern.AssertTrue(club.District.IsValid(), "O distrito invalido")
                );
        }
    }
}
