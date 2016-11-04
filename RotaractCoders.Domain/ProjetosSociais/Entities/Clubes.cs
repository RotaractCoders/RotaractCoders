using System.Collections.Generic;

namespace RotaractCoders.Domain.ProjetosSociais.Entities
{
    public class Clubes : List<Clube>
    {
        public Clubes(IEnumerable<Clube> clubes)
        {
            base.AddRange(clubes);
        }
    }
}
