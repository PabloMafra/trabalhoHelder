﻿using apiFuncionarios.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apiFuncionarios.Data.Map
{
    public class EstoqueMap : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Litragem).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
