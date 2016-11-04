using RotaractCoders.Domain.ProjetosSociais.Contracts.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RotaractCoders.Domain.ProjetosSociais.Entities;
using RotaractCoders.Infraestructure.Data;
using MongoDB.Driver.Linq;

namespace RotaractCoders.ApplicationService.ProjetosSociais.Applications
{
    public class ProjetoApplication : IProjetoApplication
    {
        private AppDataContext _context;

        public ProjetoApplication(AppDataContext context)
        {
            _context = context;
        }

        public Projeto Buscar(Guid id)
        {
            return _context.Projeto
                .AsQueryable()
                .FirstOrDefault(x => x.Id == id);
        }

        public Projetos BuscarPorClube(Guid idClube)
        {
            return new Projetos(_context.Projeto
                .AsQueryable()
                .Where(x => x.Clube.Id == idClube));
        }

        public Projetos BuscarPorDistrito(string numeroDistrito)
        {
            return new Projetos(_context.Projeto
                .AsQueryable()
                .Where(x => x.Clube.Distrito.Numero == numeroDistrito));
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
