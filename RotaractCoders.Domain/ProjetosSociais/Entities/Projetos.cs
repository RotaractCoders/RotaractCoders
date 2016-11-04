using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.ProjetosSociais.Entities
{
    public class Projetos : List<Projeto>
    {
        public Projetos(IEnumerable<Projeto> projetos)
        {
            base.AddRange(projetos);
        }
    }
}
