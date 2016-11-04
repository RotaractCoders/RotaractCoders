using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;

namespace RotaractCoders.Domain.ProjetosSociais.Contracts.Application
{
    public interface IDistritoApplication : IDisposable
    {
        Distritos Buscar();
    }
}