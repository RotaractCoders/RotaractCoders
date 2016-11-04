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
    public class ClubeApplication : IClubeApplication
    {
        private AppDataContext _context;

        public ClubeApplication(AppDataContext context)
        {
            _context = context;
        }

        public Clube Buscar(Guid id)
        {
            return _context.Clube
                .AsQueryable()
                .FirstOrDefault(x => x.Id == id);
        }

        public Clubes Buscar(string numeroDistrito)
        {
            return new Clubes(_context.Clube
                .AsQueryable()
                .Where(x => x.Distrito.Numero == numeroDistrito));
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
