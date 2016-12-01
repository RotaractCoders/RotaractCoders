using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RotaractCoders.Domain.ProjetosSociais.Contracts.Infraestructure.Data.Repository;
using System;
using System.Threading.Tasks;
using RotaractCoders.Domain.ProjetosSociais.Commands.ProjetoCommands;

namespace RotaractCoders.API.Controllers
{
    [Route("api/[controller]")]
    public class ProjetosController : Controller
    {
        private IProjetoRepository _projetoRepository;

        public ProjetosController(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get(ProjetoBuscarCommand command)
        {
            try
            {
                return Ok(_projetoRepository.Buscar(command));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("buscar/{codigo}")]
        public async Task<IActionResult> Buscar(int codigo)
        {
            return Ok(_projetoRepository.Buscar(codigo));
        }
    }
}
