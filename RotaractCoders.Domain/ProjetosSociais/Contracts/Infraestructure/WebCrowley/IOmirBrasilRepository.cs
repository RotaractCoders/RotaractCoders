using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.WebCrowley
{
    public interface IOmirBrasilRepository : IDisposable
    {
        Projeto GetByCode(int code);
    }
}
