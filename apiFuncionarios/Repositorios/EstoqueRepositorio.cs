using ProjetoGuardaChuva.Data;
using ProjetoGuardaChuva.Models;
using ProjetoGuardaChuva.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ProjetoGuardaChuva.Repositorios
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
