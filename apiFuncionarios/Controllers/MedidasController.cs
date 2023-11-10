using apiFuncionarios.Models;
using apiFuncionarios.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace apiFuncionarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedidasController : ControllerBase
    {
        private readonly IMedidasRepositorio _medidasRepositorio;

        public MedidasController(IMedidasRepositorio medidasRepositorio)
        {
            _medidasRepositorio = medidasRepositorio;
        }

        [HttpPost]
        [Route("cadastro")]
        public async Task<ActionResult<Medidas>> CadastrarMedidas([FromBody] Medidas medidas)
        {
            Medidas medidas = await _medidasRepositorio.CadastrarMedidas(medidas);

            return Ok(medidas);
        }
    }
}
