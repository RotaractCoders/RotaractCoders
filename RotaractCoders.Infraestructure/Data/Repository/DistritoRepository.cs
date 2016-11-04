using RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.Data.Repository;
using System;
using System.Linq;
using RotaractCoders.Domain.ProjetosSociais.Entities;
using MongoDB.Driver.Linq;

namespace RotaractCoders.Infraestructure.Data.Repository
{
    public class DistritoRepository : IDistritoRepository
    {
        private AppDataContext _context;

        public DistritoRepository(AppDataContext context)
        {
            _context = context;
        }

        public Distrito Buscar(string numero)
        {
            return _context.Distrito
                .AsQueryable()
                .FirstOrDefault(x => x.Numero == numero);
        }

        public Guid Salvar(Distrito distrito)
        {
            _context.Distrito.Save(distrito);
            return distrito.Id;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
