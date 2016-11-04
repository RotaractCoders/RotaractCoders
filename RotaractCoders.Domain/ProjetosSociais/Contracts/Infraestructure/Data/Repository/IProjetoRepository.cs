﻿using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;

namespace RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.Data.Repository
{
    public interface IProjetoRepository : IDisposable
    {
        Guid Save(Projeto projeto);

        Projeto Buscar(int codigo);
    }
}
