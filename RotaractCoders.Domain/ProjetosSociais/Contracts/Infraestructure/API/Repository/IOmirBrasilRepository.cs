using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;

namespace RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.API.Repository
{
    public interface IOmirBrasilRepository : IDisposable
    {
        Projeto GetByCode(int code);
    }
}
