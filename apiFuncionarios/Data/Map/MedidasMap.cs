using apiFuncionarios.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace apiFuncionarios.Data.Map
{

    public class MedidasMap : IEntityTypeConfiguration<Medidas>
    {
        public void Configure(EntityTypeBuilder<Medidas> builder)
        {
            builder.HasKey(x => x.Id);

            // Definir a propriedade IdEndereco como chave estrangeira
            builder.Property(x => x.IdEndereco)
                .IsRequired();

            // Definir o relacionamento com a tabela Endereco
            builder.HasOne(x => x.Endereco)
                .WithMany() // Ou use .WithOne se for um relacionamento um-para-um
                .HasForeignKey(x => x.IdEndereco);

            // Configurar o nome da chave estrangeira, se desejar
            builder.HasOne(x => x.Endereco)
                .WithMany()
                .HasForeignKey(x => x.IdEndereco)
                .HasConstraintName("FK_Medidas_Endereco");

        }
    }
}

