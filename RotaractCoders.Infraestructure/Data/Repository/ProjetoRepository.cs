using System;
using System.Linq;
using RotaractCoders.Domain.Model;
using RotaractCoders.Domain.Contracts.Infraestructure.Data.Repository;

namespace RotaractCoders.Infraestructure.Data.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        private AppDataContext _context;

        public ProjetoRepository(AppDataContext context)
        {
            _context = context;
        }

        public Project Get(Guid id)
        {
            return _context.Projetos.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Project projeto)
        {
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
