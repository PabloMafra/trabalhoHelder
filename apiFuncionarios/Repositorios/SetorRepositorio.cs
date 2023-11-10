using ProjetoGuardaChuva.Data;
using ProjetoGuardaChuva.Models;
using ProjetoGuardaChuva.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ProjetoGuardaChuva.Repositorios
{
    public class SetorRepositorio : ISetorRepositorio
    {
        private readonly SistemaDBContext _dbContext;
        public SetorRepositorio(SistemaDBContext sistemaDBContext)
        {
            _dbContext = sistemaDBContext;
        }

        public async Task<Setor> CadastrarSetor(Setor nomeSetor)
        {
            _dbContext.Setor.Add(nomeSetor);

            await _dbContext.SaveChangesAsync();

            return nomeSetor;
        }

    }
}
