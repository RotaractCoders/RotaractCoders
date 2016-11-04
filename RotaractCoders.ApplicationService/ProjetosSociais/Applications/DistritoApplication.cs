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
    public class DistritoApplication : IDistritoApplication
    {
        private AppDataContext _context;

        public DistritoApplication(AppDataContext context)
        {
            _context = context;
        }

        public Distritos Buscar()
        {
            return new Distritos(_context.Distrito
                .AsQueryable());
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
