using DomainNotificationHelper.Validation;
using RotaractCoders.Domain.ProjetosSociais.Entities;

namespace RotaractCoders.Domain.ProjetosSociais.Scopes
{
    public static class AtividadeScopes
    {
        public static bool ScopeIsValid(this Atividade atividade)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNull(atividade.Data, "A data é obrigatória"),
                    AssertionConcern.AssertNotEmpty(atividade.Descricao, "A descrição é obrigatória")
                );
        }
    }
}
