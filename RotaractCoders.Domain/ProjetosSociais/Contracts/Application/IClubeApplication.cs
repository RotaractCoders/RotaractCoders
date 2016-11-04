using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.ProjetosSociais.Contracts.Application
{
    public interface IClubeApplication : IDisposable
    {
        Clubes Buscar(string numeroDistrito);

        Clube Buscar(Guid id);
    }
}
