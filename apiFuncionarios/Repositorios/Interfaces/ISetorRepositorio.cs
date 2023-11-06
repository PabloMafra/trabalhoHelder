using apiFuncionarios.Models;

namespace apiFuncionarios.Repositorios.Interfaces
{
    public interface ISetorRepositorio
    {
        Task<Setor> CadastrarSetor(Setor nomeSetor);
    }
}
