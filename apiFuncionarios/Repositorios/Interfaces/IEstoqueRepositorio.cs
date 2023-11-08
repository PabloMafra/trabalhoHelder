using apiFuncionarios.Models;

namespace apiFuncionarios.Repositorios.Interfaces
{
    public interface IEstoqueRepositorio
    {
        Task<Estoque> CadastrarEstoque(Estoque litragem);
    }
}

