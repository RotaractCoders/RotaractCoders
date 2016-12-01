using RotaractCoders.Domain.ProjetosSociais.Commands.ProjetoCommands;
using RotaractCoders.Domain.ProjetosSociais.Entities;
using RotaractCoders.Domain.ProjetosSociais.ViewModels;
using RotaractCoders.Domain.ProjetosSociais.ViewModels.Projeto;
using System;
using System.Collections.Generic;

namespace RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.Data.Repository
{
    public interface IProjetoRepository : IDisposable
    {
        Guid Save(Projeto projeto);

        Projeto Buscar(int codigo);

        ProjetoBuscarViewModel Buscar(ProjetoBuscarCommand command);
    }
}
