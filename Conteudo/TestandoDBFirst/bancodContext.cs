using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TestandoDBFirst
{
    public partial class bancodContext : DbContext
    {
        public bancodContext()
        {
        }

        public bancodContext(DbContextOptions<bancodContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Pedido> Pedidos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=bancod;User ID=sa;Password=Gabri123!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("clientes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.ToTable("pedidos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datapedido)
                    .HasColumnType("date")
                    .HasColumnName("datapedido");

                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("valor");

                entity.HasOne(d => d.FkClienteNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.FkCliente)
                    .HasConstraintName("FK__pedidos__fk_clie__4F7CD00D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
