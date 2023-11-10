using ProjetoGuardaChuva.Data;
using ProjetoGuardaChuva.Models;
using ProjetoGuardaChuva.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace ProjetoGuardaChuva.Repositorios
{
  public class MedidasRepositorio : IMedidasRepositorio
        {
            private readonly SistemaDBContext _dbContext;
            public MedidasRepositorio(SistemaDBContext sistemaDBContext)
            {
                _dbContext = sistemaDBContext;
            }

            public async Task<Medidas> CadastroMedidas(Medidas medidas)
            {
                _dbContext.Medidas.Add(medidas);

                await _dbContext.SaveChangesAsync();

                return medidas;
            }

        }
    }

