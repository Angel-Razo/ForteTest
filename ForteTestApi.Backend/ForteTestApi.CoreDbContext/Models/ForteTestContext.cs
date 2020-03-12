using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ForteTestApi.CoreDbContext.Models
{
    public partial class ForteTestContext : DbContext
    {
        public ForteTestContext()
        {
        }

        public ForteTestContext(DbContextOptions<ForteTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbCliente> TbCliente { get; set; }
        public virtual DbSet<TbEstatusCliente> TbEstatusCliente { get; set; }
        public virtual DbSet<TbIauditable> TbIauditable { get; set; }
        public virtual DbSet<TbIsoftDelete> TbIsoftDelete { get; set; }
        public virtual DbSet<TbPersona> TbPersona { get; set; }
        public virtual DbSet<TbPersona1> TbPersona1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=X220\\SQLEXPRESS; User ID=Sa; Initial Catalog=ForteTest; Password=Admin123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.ClienteId)
                    .HasName("PK__TbClient__71ABD087493CFD0F");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdIauditable).HasColumnName("IdIAuditable");

                entity.Property(e => e.IdIsoftDelete).HasColumnName("IdISoftDelete");

                entity.Property(e => e.LimiteCredito).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstatusClienteNavigation)
                    .WithMany(p => p.TbCliente)
                    .HasForeignKey(d => d.IdEstatusCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TbCliente__IdEst__2B3F6F97");

                entity.HasOne(d => d.IdIauditableNavigation)
                    .WithMany(p => p.TbCliente)
                    .HasForeignKey(d => d.IdIauditable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TbCliente__IdIAu__2D27B809");

                entity.HasOne(d => d.IdIsoftDeleteNavigation)
                    .WithMany(p => p.TbCliente)
                    .HasForeignKey(d => d.IdIsoftDelete)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TbCliente__IdISo__2C3393D0");
            });

            modelBuilder.Entity<TbEstatusCliente>(entity =>
            {
                entity.HasKey(e => e.IdEstatusCliente)
                    .HasName("PK__TbEstatu__90BBE0F97E428BB5");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbIauditable>(entity =>
            {
                entity.HasKey(e => e.IdIauditable)
                    .HasName("PK__TbIAudit__2F6C0EAA1177CC5E");

                entity.ToTable("TbIAuditable");

                entity.Property(e => e.IdIauditable).HasColumnName("IdIAuditable");

                entity.Property(e => e.CreadoEl).HasColumnType("datetime");

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EliminadoEl).HasColumnType("datetime");

                entity.Property(e => e.EliminadoPor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModificadoEl).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbIsoftDelete>(entity =>
            {
                entity.HasKey(e => e.IdIsoftDelete)
                    .HasName("PK__TbISoftD__A89AA3BBF4BA24AA");

                entity.ToTable("TbISoftDelete");

                entity.Property(e => e.IdIsoftDelete).HasColumnName("IdISoftDelete");
            });

            modelBuilder.Entity<TbPersona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__Tb_Perso__2EC8D2AC6CD35B52");

                entity.ToTable("Tb_Persona");

                entity.Property(e => e.Fechanacimiento).HasColumnType("datetime");

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPersona1>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__TbPerson__2EC8D2AC7BE6EC68");

                entity.ToTable("TbPersona");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
