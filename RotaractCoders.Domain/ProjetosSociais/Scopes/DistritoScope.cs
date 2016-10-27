using DomainNotificationHelper.Validation;
using RotaractCoders.Domain.ProjetosSociais.Entities;

namespace RotaractCoders.Domain.ProjetosSociais.Scopes
{
    public static class DistritoScope
    {
        public static bool ScopeIsValid(this Distrito distrito)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(distrito.Id.ToString(), "O código é obrigatório"),
                    AssertionConcern.AssertNotEmpty(distrito.Numero, "O número é obrigatório"),
                    AssertionConcern.AssertLength(distrito.Numero, 4, 4, "O número do distrito deve ter 4 caracteres")
                );
        }
    }
}
