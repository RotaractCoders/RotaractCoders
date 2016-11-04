using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.ProjetosSociais.Contracts.Application
{
    public interface IOmirBrasilApplication : IDisposable
    {
        bool PersistirProjeto(int codigo);
    }
}
