using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoGuardaChuva.Models;
using ProjetoGuardaChuva.Repositorios.Interfaces;
using Microsoft.AspNetCore.Cors;

namespace ProjetoGuardaChuva.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetorController : ControllerBase
    {
        private readonly ISetorRepositorio _setorRepositorio;

        public SetorController(ISetorRepositorio setorRepositorio)
        {
            _setorRepositorio = setorRepositorio;
        }

        [HttpPost]
        [Route("cadastro")]
        public async Task<ActionResult<Setor>> CadastrarUsuario([FromBody] Setor nomeSetor)
        {
            Setor setor = await _setorRepositorio.CadastrarSetor(nomeSetor);

            return Ok(setor);
        }
    }
}
