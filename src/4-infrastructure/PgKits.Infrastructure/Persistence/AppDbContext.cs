using Microsoft.EntityFrameworkCore;
using PgKits.Domain.Entities;

namespace PgKits.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Kit> Kits { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<KitItem> KitItens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapear tabelas existentes
            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("itens");
                entity.HasKey(e => e.Id);

                entity.HasOne(e => e.Fornecedor)
                      .WithMany(f => f.Itens)
                      .HasForeignKey(e => e.FornecedorId)
                      .HasConstraintName("FK_itens_Fornecedores_FornecedorId");
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.ToTable("fornecedores");
            });

            modelBuilder.Entity<Kit>(entity =>
            {
                entity.ToTable("kits");
            });

            modelBuilder.Entity<KitItem>()
                .HasKey(ki => new { ki.KitId, ki.ItemId });
        }
    }
}
