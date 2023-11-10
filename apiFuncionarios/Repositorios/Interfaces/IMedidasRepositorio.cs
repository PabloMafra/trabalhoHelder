using ProjetoGuardaChuva.Models;

namespace ProjetoGuardaChuva.Repositorios.Interfaces
{
    public interface IMedidasRepositorio
    {
        Task<Medidas> CadastroMedidas(Medidas medidas);
    }
}
