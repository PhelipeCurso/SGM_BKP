using Dominio.Models.Entities.Financeiro;
using Dominio.Models.Entities.Igreja;
using Dominio.Models.Entities.Pessoa;
using Dominio.Models.Entities.Usuarios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Infraestrutura.Data.Context
{
    public class SGMContext : DbContext
    {
        public SGMContext(DbContextOptions<SGMContext> options) : base(options) { }

        public DbSet<Igreja> Igrejas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Membro> Membros { get; set; }
        public DbSet<Financeiro> TransacoesFinanceiras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
               .SelectMany(e => e.GetProperties()
                   .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SGMContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
