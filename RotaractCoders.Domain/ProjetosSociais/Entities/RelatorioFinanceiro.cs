using System.Collections.Generic;
using System.Linq;

namespace RotaractCoders.Domain.ProjetosSociais.Entities
{
    public class RelatorioFinanceiro : List<Financas>
    {
        public decimal Quantidaderegistros => this.Sum(x => x.Valor);
    }
}
