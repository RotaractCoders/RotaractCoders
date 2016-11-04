using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.ProjetosSociais.Contracts.Application
{
    public interface IProjetoApplication : IDisposable
    {
        Projetos BuscarPorClube(Guid idClube);

        Projetos BuscarPorDistrito(string numeroDistrito);

        Projeto Buscar(Guid id);
    }
}
