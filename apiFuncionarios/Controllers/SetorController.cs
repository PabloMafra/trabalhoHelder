using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using apiFuncionarios.Models;
using apiFuncionarios.Repositorios.Interfaces;
using Microsoft.AspNetCore.Cors;

namespace apiFuncionarios.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowReactApp")]
    [ApiController]
    public class SetorController : ControllerBase
    {
        private readonly IFuncionarioRepositorio _setorRepositorio;

        public SetorController(IFuncionarioRepositorio setorRepositorio)
        {
            _setorRepositorio = setorRepositorio;
        }

        [HttpPost]
        [Route("cadastro")]
        public async Task<ActionResult<Funcionario>> CadastrarUsuario([FromQuery] Funcionario nomeSetor)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");

            Funcionario setor = await _setorRepositorio.CadastrarFuncionario(nomeSetor);

            return Ok(setor);
        }
    }
}
