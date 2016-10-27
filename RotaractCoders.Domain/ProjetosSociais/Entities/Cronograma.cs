using System.Collections.Generic;

namespace RotaractCoders.Domain.ProjetosSociais.Entities
{
    public class Cronograma : List<Atividade>
    {
        public Cronograma()
        {

        }

        public Cronograma(List<Atividade> atividades)
        {
            base.AddRange(atividades);
        }

        public int QuantidadeDeAtividades => this.Count;
    }
}
