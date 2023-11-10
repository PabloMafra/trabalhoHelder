using ProjetoGuardaChuva.Models;

namespace ProjetoGuardaChuva.Repositorios.Interfaces
{
    public interface ISetorRepositorio
    {
        Task<Setor> CadastrarSetor(Setor nomeSetor);
    }
}
