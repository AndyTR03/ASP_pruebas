using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVCCRUD.Models
{
    public partial class MVCCRUDContext : DbContext
    {
        public MVCCRUDContext()
        {
        }

        public MVCCRUDContext(DbContextOptions<MVCCRUDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("server=localhost; database=MVCCRUD; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Clave)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.Property(e => e.Usuario) 
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contraseña) 
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
