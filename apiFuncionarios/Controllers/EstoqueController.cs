using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoGuardaChuva.Models;
using ProjetoGuardaChuva.Repositorios.Interfaces;
using Microsoft.AspNetCore.Cors;

namespace ProjetoGuardaChuva.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueController : ControllerBase
    {
        private readonly IEstoqueRepositorio _estoqueRepositorio;

        public EstoqueController(IEstoqueRepositorio estoqueRepositorio)
        {
            _estoqueRepositorio = estoqueRepositorio;
        }

        [HttpPost]
        [Route("cadastro")]
        public async Task<ActionResult<Estoque>> CadastrarEstoque([FromBody] Estoque litragem)
        {
            Estoque estoque = await _estoqueRepositorio.CadastrarEstoque(litragem);

            return Ok(estoque);
        }
    }
}
