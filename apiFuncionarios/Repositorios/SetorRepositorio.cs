﻿using apiFuncionarios.Data;
using apiFuncionarios.Models;
using apiFuncionarios.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace apiFuncionarios.Repositorios
{
    public class SetorRepositorio : ISetorRepositorio
    {
        private readonly SistemaDBContext _dbContext;
        public SetorRepositorio(SistemaDBContext sistemaDBContext)
        {
            _dbContext = sistemaDBContext;
        }

        public async Task<Setor> CadastrarSetor(Setor nomeSetor)
        {
            _dbContext.Setor.Add(nomeSetor);

            await _dbContext.SaveChangesAsync();

            return nomeSetor;
        }

    }
}
