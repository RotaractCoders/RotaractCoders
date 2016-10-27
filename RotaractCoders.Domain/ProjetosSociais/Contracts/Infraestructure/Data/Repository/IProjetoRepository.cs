using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;

namespace RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.Data.Repository
{
    public interface IProjetoRepository : IDisposable
    {
        Projeto Get(Guid id);

        void Create(Projeto projeto);
    }
}
