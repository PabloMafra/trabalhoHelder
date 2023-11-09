using apiFuncionarios.Models;

namespace apiFuncionarios.Repositorios.Interfaces
{
    public interface IMedidasRepositorio
    {
        Task<Setor> CadastroMedidas(Setor nomeSetor);
    }
}
