using RotaractCoders.Domain.ProjetosSociais.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.ProjetosSociais.ViewModels.Projeto
{
    public class ProjetoBuscarViewModel
    {
        public int QuantidadePaginas { get; private set; }

        public int Pagina { get; private set; }

        public List<projetoBasicoViewModel> Projetos { get; private set; }

        public ProjetoBuscarViewModel(int quantidadePaginas, int pagina, Projetos projetos)
        {
            QuantidadePaginas = quantidadePaginas;
            Pagina = pagina;
            Projetos = projetos.Select(x => new projetoBasicoViewModel
            {
                Clube = x.Clube.Nome,
                Nome = x.Nome,
                Distrito = x.Clube.Distrito.Numero.ToString(),
                CodigoClube = x.Clube.Codigo
            }).ToList();
        }
    }

    public struct projetoBasicoViewModel
    {
        public int CodigoClube { get; set; }
        public string Nome { get; set; }
        public string Clube { get; set; }
        public string Distrito { get; set; }
    }
}
