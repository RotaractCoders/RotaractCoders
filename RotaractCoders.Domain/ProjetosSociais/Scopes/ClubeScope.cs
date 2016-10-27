using DomainNotificationHelper.Validation;
using RotaractCoders.Domain.ProjetosSociais.Entities;

namespace RotaractCoders.Domain.ProjetosSociais.Scopes
{
    public static class ClubeScope
    {
        public static bool ScopeIsValid(this Clube clube)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(clube.Id.ToString(), "O id é obrigatório"),
                    AssertionConcern.AssertTrue(clube.Codigo > 0, "O código é obrigatório"),
                    AssertionConcern.AssertNotEmpty(clube.Nome, "O nome do clube é obrigatório"),
                    AssertionConcern.AssertNotNull(clube.Distrito, "O distrito é obrigatório"),
                    AssertionConcern.AssertTrue(clube.Distrito.Valido(), "O distrito invalido")
                );
        }
    }
}
