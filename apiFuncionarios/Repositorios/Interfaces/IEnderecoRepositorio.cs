using ProjetoGuardaChuva.Models;

namespace ProjetoGuardaChuva.Repositorios.Interfaces
{
    public interface IEnderecoRepositorio
    {
        Task<Endereco> CadastrarEndereco(Endereco endereco);
    }
}
