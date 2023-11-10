using apiFuncionarios.Models;

namespace apiFuncionarios.Repositorios.Interfaces
{
    public interface IMedidasRepositorio
    {
        Task<Medidas> CadastroMedidas(Medidas medidas);
    }
}
