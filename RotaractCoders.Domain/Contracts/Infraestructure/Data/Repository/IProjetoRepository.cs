using RotaractCoders.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.Contracts.Infraestructure.Data.Repository
{
    public interface IProjetoRepository : IDisposable
    {
        Project Get(Guid id);

        void Create(Project projeto);
    }
}
