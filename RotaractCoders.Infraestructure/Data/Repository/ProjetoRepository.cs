﻿using RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.Data.Repository;
using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;
using MongoDB.Driver.Linq;
using System.Linq;

namespace RotaractCoders.Infraestructure.Data.Repository
{
    public class ProjetoRepository : IProjetoRepository
    {
        private AppDataContext _context;

        public ProjetoRepository(AppDataContext context)
        {
            _context = context;
        }

        public Projeto Buscar(int codigo)
        {
            return _context.Projeto
                .AsQueryable()
                .FirstOrDefault(x => x.Codigo == codigo);
        }

        public Guid Save(Projeto projeto)
        {
            _context.Projeto.Save(projeto);
            return projeto.Id;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}