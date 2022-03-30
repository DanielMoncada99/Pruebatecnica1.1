using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Pruebatecnica1._1.Models.dbModels
{
    public partial class CarrosContext : IdentityDbContext<AplicationUser, IdentityRole<int>, int>
    {
        public CarrosContext()
        {
        }

        public CarrosContext(DbContextOptions<CarrosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carro> Carros { get; set; } = null!;
        public virtual DbSet<Carrotipo> Carrotipos { get; set; } = null!;
        public virtual DbSet<Wcarro> Wcarros { get; set; } = null!;

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>(entity =>
            {
                base.OnModelCreating(modelBuilder);
                entity.Property(e => e.Modelo).IsFixedLength();

                entity.Property(e => e.Nombrecarro).IsFixedLength();

                entity.HasOne(d => d.TipocarroNavigation)
                    .WithMany(p => p.Carros)
                    .HasForeignKey(d => d.Tipocarro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_carros_carrotipo");
                entity.HasOne(d => d.IdusuarioNavigations)
                 .WithMany(p => p.Carros)
                 .HasForeignKey(d => d.Idusuario)
                 .HasConstraintName("FK_Carro_Usuario");

            });

            modelBuilder.Entity<Carrotipo>(entity =>
            {
                entity.Property(e => e.Descripcion).IsFixedLength();
            });

            modelBuilder.Entity<Wcarro>(entity =>
            {
                entity.ToView("wcarro");

                entity.Property(e => e.Modelo).IsFixedLength();

                entity.Property(e => e.Nombrecarro).IsFixedLength();

                entity.Property(e => e.Tipocarrodescripcion).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
