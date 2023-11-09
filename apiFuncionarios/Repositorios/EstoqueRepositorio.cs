using apiFuncionarios.Data;
using apiFuncionarios.Models;
using apiFuncionarios.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace apiFuncionarios.Repositorios
{
    public class EstoqueRepositorio : IEstoqueRepositorio
    {
        private readonly SistemaDBContext _dbContext;
        public EstoqueRepositorio(SistemaDBContext sistemaDBContext)
        {
            _dbContext = sistemaDBContext;
        }

        public async Task<Estoque> CadastrarEstoque(Estoque litragem)
        {
            _dbContext.Estoque.Add(litragem);

            await _dbContext.SaveChangesAsync();

            return litragem;
        }

    }
}
