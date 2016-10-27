using DomainNotificationHelper.Validation;
using RotaractCoders.Domain.ProjetosSociais.Entities;

namespace RotaractCoders.Domain.ProjetosSociais.Scopes
{
    public static class FinancasScope
    {
        public static bool ScopeIsValid(this Financas financas)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNull(financas.Data, "A data é obrigatória"),
                    AssertionConcern.AssertNotEmpty(financas.Descricao, "A descrição é obrigatória"),
                    AssertionConcern.AssertNotNull(financas.Valor, "O valor é obrigatório")
                );
        }
    }
}
