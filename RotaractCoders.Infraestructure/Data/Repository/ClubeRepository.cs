using RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RotaractCoders.Domain.ProjetosSociais.Entities;
using MongoDB.Driver.Linq;

namespace RotaractCoders.Infraestructure.Data.Repository
{
    public class ClubeRepository : IClubeRepository
    {
        private AppDataContext _context;

        public ClubeRepository(AppDataContext context)
        {
            _context = context;
        }

        public Clube Buscar(int codigo)
        {
            return _context.Clube
                .AsQueryable()
                .FirstOrDefault(x => x.Codigo == codigo);
        }

        public Guid Salvar(Clube clube)
        {
            _context.Clube.Save(clube);
            return clube.Id;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
