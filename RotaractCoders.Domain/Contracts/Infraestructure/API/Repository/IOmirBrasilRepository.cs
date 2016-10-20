using RotaractCoders.Domain.Model;
using System;

namespace RotaractCoders.Domain.Contracts.Infraestructure.API.Repository
{
    public interface IOmirBrasilRepository : IDisposable
    {
        Project GetByCode(int code);
    }
}
