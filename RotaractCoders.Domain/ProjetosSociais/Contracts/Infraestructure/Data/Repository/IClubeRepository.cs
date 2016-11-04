using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.Data.Repository
{
    public interface IClubeRepository : IDisposable
    {
        Guid Salvar(Clube clube);

        Clube Buscar(int codigo);
    }
}
