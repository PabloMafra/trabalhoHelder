using ProjetoGuardaChuva.Models;
using ProjetoGuardaChuva.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoGuardaChuva.Controllers
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
        public async Task<ActionResult<Medidas>> CadastrarMedidas([FromBody] Medidas inputmedidas)
        {
            Medidas medidas = await _medidasRepositorio.CadastroMedidas(inputmedidas);

            return Ok(medidas);
        }
    }
}
