using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;

namespace RotaractCoders.Domain.Contracts.Services
{
    public interface IWebCrowleyOmirService : IDisposable
    {
        Projeto BuscarProjeto(int codigo);
    }
}