using apiFuncionarios.Models;
using apiFuncionarios.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace apiFuncionarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoRepositorio _enderecoRepositorio;

        public EnderecoController(IEnderecoRepositorio enderecoRepositorio)
        {
            _enderecoRepositorio = enderecoRepositorio;
        }

        [HttpPost]
        [Route("cadastro")]
        public async Task<ActionResult<Endereco>> CadastrarEndereco([FromBody] Endereco inputEndereco)
        {
            Endereco endereco = await _enderecoRepositorio.CadastrarEndereco(inputEndereco);

            return Ok(endereco);
        }
    }
}

}
