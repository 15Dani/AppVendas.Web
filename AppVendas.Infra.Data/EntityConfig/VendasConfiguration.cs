using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using AppVendas.Domain.Entities;

namespace AppVendas.Infra.Data.EntityConfig
{
    public class VendasConfiguration : IEntityTypeConfiguration<Vendas>
    {
        public void Configure(EntityTypeBuilder<Vendas> builder)
        {
            //builder.ToTable("Vendas");

            //builder.HasKey(p => p.Id);

            //builder.Property(p => p.Nm_cliente).IsRequired().HasMaxLength(200).HasColumnName("Nome");
        }
    }
}
