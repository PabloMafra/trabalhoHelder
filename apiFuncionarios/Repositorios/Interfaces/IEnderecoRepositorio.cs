using apiFuncionarios.Models;

namespace apiFuncionarios.Repositorios.Interfaces
{
    public interface IEnderecoRepositorio
    {
        Task<Endereco> CadastrarEndereco(Endereco endereco);
    }
}
