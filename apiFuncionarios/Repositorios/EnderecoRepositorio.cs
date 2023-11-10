using ProjetoGuardaChuva.Data;
using ProjetoGuardaChuva.Models;
using ProjetoGuardaChuva.Repositorios.Interfaces;

namespace ProjetoGuardaChuva.Repositorios
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private readonly SistemaDBContext _dbContext;
        public EnderecoRepositorio(SistemaDBContext sistemaDBContext)
        {
            _dbContext = sistemaDBContext;
        }

        public async Task<Endereco> CadastrarEndereco(Endereco endereco)
        {
            _dbContext.Endereco.Add(endereco);

            await _dbContext.SaveChangesAsync();

            return endereco;
        }

    }
}
