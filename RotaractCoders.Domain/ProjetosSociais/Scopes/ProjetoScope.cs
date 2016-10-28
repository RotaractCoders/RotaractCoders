using DomainNotificationHelper.Validation;
using RotaractCoders.Domain.ProjetosSociais.Entities;
using System.Linq;

namespace RotaractCoders.Domain.ProjetosSociais.Scopes
{
    public static class ProjetoScope
    {
        public static bool ScopeIsValid(this Projeto projeto)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(projeto.Id.ToString(), "O id é obrigatório"),
                    AssertionConcern.AssertTrue(projeto.Codigo > 0, "O codigo é obrigatório"),
                    AssertionConcern.AssertNotNull(projeto.Clube, "O clube é obrigatório"),
                    AssertionConcern.AssertTrue(projeto.Clube.Valido(), "O clube invalido"),
                    AssertionConcern.AssertNotNull(projeto.DataUltimaAtualizacao, "A data da ultima atualização é obrigatória"),
                    AssertionConcern.AssertNotNull(projeto.Nome, "O nome é obrigatório"),
                    AssertionConcern.AssertNotNull(projeto.Descricao, "A descrição é obrigatória"),
                    AssertionConcern.AssertNotNull(projeto.ObjetivosGerais, "O objetivo geral é obrigatório"),
                    AssertionConcern.AssertNotNull(projeto.ObjetivosEspecificos, "O objetivo especifico é obrigatório"),
                    AssertionConcern.AssertNotNull(projeto.CategoriasPrincipais, "A categoria principal é obrigatória")
                );
        }
    }
}
