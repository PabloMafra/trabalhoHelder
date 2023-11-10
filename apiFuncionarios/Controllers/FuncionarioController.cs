using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoGuardaChuva.Models;
using ProjetoGuardaChuva.Repositorios.Interfaces;
using Microsoft.AspNetCore.Cors;

namespace ProjetoGuardaChuva.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowReactApp")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;

        public FuncionarioController(IFuncionarioRepositorio funcionarioRepositorio)
        {
            _funcionarioRepositorio = funcionarioRepositorio;
        }

        [HttpGet]
        [Route("busca")]
        public async Task<ActionResult<List<Funcionario>>> BuscarFuncionarios([FromQuery] string? nome)
        {
            List<Funcionario> funcionarios;

            Response.Headers.Add("Access-Control-Allow-Origin", "*");

            if (string.IsNullOrEmpty(nome))
            {
                funcionarios = await _funcionarioRepositorio.ListarFuncionarios();
                
            }
            else
            {
                funcionarios = await _funcionarioRepositorio.BuscarFuncionarios(nome);
            }

            return Ok(funcionarios);

        }

        [HttpPost]
        [Route("cadastro")]
        public async Task<ActionResult<Funcionario>> CadastrarUsuario([FromQuery] Funcionario usuario)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");

            Funcionario user = await _funcionarioRepositorio.CadastrarFuncionario(usuario);

            return Ok(user);
        }
    }
}
