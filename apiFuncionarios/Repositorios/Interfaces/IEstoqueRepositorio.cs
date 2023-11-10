using ProjetoGuardaChuva.Models;

namespace ProjetoGuardaChuva.Repositorios.Interfaces
{
    public interface IEstoqueRepositorio
    {
        Task<Estoque> CadastrarEstoque(Estoque litragem);
    }
}

