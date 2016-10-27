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
                    AssertionConcern.AssertNotEmpty(projeto.Justificativa, "A justificativa é obrigatória"),
                    AssertionConcern.AssertNotNull(projeto.ObjetivosGerais, "O objetivo geral é obrigatório"),
                    AssertionConcern.AssertNotNull(projeto.ObjetivosEspecificos, "O objetivo especifico é obrigatório"),
                    AssertionConcern.AssertNotNull(projeto.CategoriasPrincipais, "A categoria principal é obrigatória"),
                    AssertionConcern.AssertNotNull(projeto.DataInicio, "A data de inicio é obrigatória"),
                    AssertionConcern.AssertTrue(projeto.DataInicio.Year > 1900, "A data de inicio não é valida"),
                    AssertionConcern.AssertNotNull(projeto.DataFim, "A data de fim é obrigatória"),
                    AssertionConcern.AssertTrue(projeto.DataFim.Year > 1900, "A data de fim não é valida"),
                    AssertionConcern.AssertNotNull(projeto.RelatorioFinanceiro, "O relatório financeiro é obrigatório"),
                    AssertionConcern.AssertTrue(projeto.RelatorioFinanceiro
                        .Select(x => x.Valido())
                        .Contains(true), "O relatório financeiro deve ser valido"),
                    AssertionConcern.AssertNotNull(projeto.Participantes, "Os participantes são obrigatórios"),
                    AssertionConcern.AssertNotEmpty(projeto.PublicoAlvo, "O publico alvo é obrigatório"),
                    AssertionConcern.AssertNotNull(projeto.MeiosDeDivulgacao, "Os meios de divulgação são obrigatórios"),
                    AssertionConcern.AssertNotNull(projeto.Parcerias, "As parcerias são obrigatórias"),
                    AssertionConcern.AssertNotNull(projeto.Cronograma, "O cronograma é obrigatório"),
                    AssertionConcern.AssertTrue(projeto.Cronograma
                        .Select(x => x.Valido())
                        .Contains(true), "O cronograma deve ser valido"),
                    AssertionConcern.AssertNotEmpty(projeto.Descricao, "A descrição é obrigatória"),
                    AssertionConcern.AssertNotEmpty(projeto.Resultados, "O resultado é obrigatório"),
                    AssertionConcern.AssertNotNull(projeto.Dificuldade, "O grau de dificuldade é obrigatório"),
                    AssertionConcern.AssertNotEmpty(projeto.PalavraChave, "As palavras chaves são obrigatórias"),
                    AssertionConcern.AssertNotEmpty(projeto.Resumo, "O resumo é obrigatório")
                );
        }
    }
}
