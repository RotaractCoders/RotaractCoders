using DomainNotificationHelper.Validation;
using RotaractCoders.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.Scopes
{
    public static class ProjectScope
    {
        public static bool ScopeIsValid(this Project project)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(project.Id.ToString(), "O id é obrigatório"),
                    AssertionConcern.AssertTrue(project.Code > 0, "O codigo é obrigatório"),
                    AssertionConcern.AssertNotNull(project.Club, "O clube é obrigatório"),
                    AssertionConcern.AssertTrue(project.Club.IsValid(), "O clube invalido"),
                    AssertionConcern.AssertNotEmpty(project.Rationale, "A justificativa é obrigatória"),
                    AssertionConcern.AssertNotNull(project.GeneralObjective, "O objetivo geral é obrigatório"),
                    AssertionConcern.AssertNotNull(project.SpecificObjective, "O objetivo especifico é obrigatório"),
                    AssertionConcern.AssertNotNull(project.MainCategory, "A categoria principal é obrigatória"),
                    AssertionConcern.AssertNotNull(project.StartDate, "A data de inicio é obrigatória"),
                    AssertionConcern.AssertTrue(project.StartDate.Year > 1900, "A data de inicio não é valida"),
                    AssertionConcern.AssertNotNull(project.EndDate, "A data de fim é obrigatória"),
                    AssertionConcern.AssertTrue(project.EndDate.Year > 1900, "A data de fim não é valida"),
                    AssertionConcern.AssertNotNull(project.ProjectFinancials, "O relatório financeiro é obrigatório"),
                    AssertionConcern.AssertTrue(project.ProjectFinancials
                        .Select(x => x.IsValid())
                        .Contains(true), "O relatório financeiro deve ser valido"),
                    AssertionConcern.AssertNotNull(project.Participants, "Os participantes são obrigatórios"),
                    AssertionConcern.AssertNotEmpty(project.TargetAudience, "O publico alvo é obrigatório"),
                    AssertionConcern.AssertNotNull(project.DisclosureMeans, "Os meios de divulgação são obrigatórios"),
                    AssertionConcern.AssertNotNull(project.Partnerships, "As parcerias são obrigatórias"),
                    AssertionConcern.AssertNotNull(project.Schedule, "O cronograma é obrigatório"),
                    AssertionConcern.AssertTrue(project.Schedule
                        .Select(x => x.IsValid())
                        .Contains(true), "O cronograma deve ser valido"),
                    AssertionConcern.AssertNotEmpty(project.Description, "A descrição é obrigatória"),
                    AssertionConcern.AssertNotEmpty(project.Results, "O resultado é obrigatório"),
                    AssertionConcern.AssertNotNull(project.Difficulty, "O grau de dificuldade é obrigatório"),
                    AssertionConcern.AssertNotEmpty(project.KeyWords, "As palavras chaves são obrigatórias"),
                    AssertionConcern.AssertNotEmpty(project.Summary, "O resumo é obrigatório")
                );
        }
    }
}
