using ProjetoGuardaChuva.Data;
using ProjetoGuardaChuva.Repositorios;
using ProjetoGuardaChuva.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace ProjetoGuardaChuva
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddEntityFrameworkSqlServer()
                    .AddDbContext<SistemaDBContext>(
                    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                );

            builder.Services.AddScoped<IFuncionarioRepositorio, FuncionarioRepositorio>();
            builder.Services.AddScoped<ISetorRepositorio, SetorRepositorio>();
            builder.Services.AddScoped<IEstoqueRepositorio, EstoqueRepositorio>();
            builder.Services.AddScoped<IMedidasRepositorio, MedidasRepositorio>();
            builder.Services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();

            var app = builder.Build();  

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(builder => builder
                .WithOrigins("http://localhost:3000")
                .AllowAnyMethod()
                .AllowAnyHeader()
            );

            app.MapControllers();

            app.Run();
        }

    }

}