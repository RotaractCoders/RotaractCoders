using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;

namespace RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.Data.Repository
{
    public interface IDistritoRepository : IDisposable
    {
        Guid Salvar(Distrito distrito);

        Distrito Buscar(string numero);
    }
}
