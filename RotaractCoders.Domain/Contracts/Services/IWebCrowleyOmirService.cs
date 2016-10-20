using RotaractCoders.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.Contracts.Services
{
    public interface IWebCrowleyOmirService : IDisposable
    {
        Project BuscarProjeto(int codigo);
    }
}