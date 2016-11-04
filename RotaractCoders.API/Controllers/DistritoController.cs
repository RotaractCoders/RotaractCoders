using Microsoft.AspNetCore.Mvc;
using RotaractCoders.Domain.ProjetosSociais.Contracts.Application;
using System.Net.Http;
using System.Threading.Tasks;

namespace RotaractCoders.API.Controllers
{
    [Route("api/[controller]")]
    public class DistritoController : Controller
    {
        private IDistritoApplication _distritoApplication;

        public DistritoController(IDistritoApplication distritoApplication)
        {
            _distritoApplication = distritoApplication;
        }

        [HttpGet]
        public IActionResult Buscar()
        {
            return Ok(_distritoApplication.Buscar());
        }
    }
}
