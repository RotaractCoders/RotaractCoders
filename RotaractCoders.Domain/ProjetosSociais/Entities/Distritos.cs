using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.ProjetosSociais.Entities
{
    public class Distritos : List<Distrito>
    {
        public Distritos(IEnumerable<Distrito> distritos)
        {
            base.AddRange(distritos);
        }
    }
}
