using RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.Data.Repository;
using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;
using MongoDB.Driver.Linq;
using System.Linq;
using RotaractCoders.Domain.ProjetosSociais.Commands.ProjetoCommands;
using RotaractCoders.Domain.ProjetosSociais.ViewModels.Projeto;
using System.Collections.Generic;

namespace RotaractCoders.Infraestructure.Data.Repository
{
    public class ProjetoRepository : IProjetoRepository
    {
        private AppDataContext _context;

        public ProjetoRepository(AppDataContext context)
        {
            _context = context;
        }

        public ProjetoBuscarViewModel Buscar(ProjetoBuscarCommand command)
        {
            var quantidadePorPagina = 10;

            var projetos = new List<Projeto>();
            var paginas = 0;

            if (!string.IsNullOrWhiteSpace(command.Distrito) && command.CodigoClube == 0)
            {
                projetos = _context.Projeto
                    .AsQueryable()
                    .Where(x => x.Clube.Distrito.Numero == command.Distrito)
                    .Skip(command.Pagina * quantidadePorPagina)
                    .Take(quantidadePorPagina)
                    .ToList();

                paginas = _context.Projeto
                    .AsQueryable()
                    .Count(x => x.Clube.Distrito.Numero == command.Distrito) / quantidadePorPagina;
            }
            else if (command.CodigoClube > 0)
            {
                projetos = _context.Projeto
                    .AsQueryable()
                    .Where(x => x.Clube.Codigo == command.CodigoClube)
                    .Skip(command.Pagina * quantidadePorPagina)
                    .Take(quantidadePorPagina)
                    .ToList();

                paginas = _context.Projeto
                    .AsQueryable()
                    .Count(x => x.Clube.Codigo == command.CodigoClube) / quantidadePorPagina;
            }
            else
            {
                projetos = _context.Projeto
                    .AsQueryable()
                    .Skip(command.Pagina * quantidadePorPagina)
                    .Take(quantidadePorPagina)
                    .ToList();

                paginas = _context.Projeto
                    .AsQueryable()
                    .Count() / quantidadePorPagina;
            }

            return new ProjetoBuscarViewModel(
                pagina: command.Pagina,
                quantidadePaginas: paginas,
                projetos: new Projetos(projetos));
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