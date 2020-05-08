using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AppVendas.Domain.Entities;
using AppVendas.Infra.Data.EntityConfig;

namespace AppVendas.Infra.Data.Context
{
    public class VendasContext : DbContext
    {
        public VendasContext(DbContextOptions<VendasContext> options) : base(options)
        {

        }

        public DbSet<Vendas> Vendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Vendas>(new VendasConfiguration().Configure);
        }
    }
}
