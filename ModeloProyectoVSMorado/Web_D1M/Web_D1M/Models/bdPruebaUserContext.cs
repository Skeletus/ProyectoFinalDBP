using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Web_D1M.Models
{
    public partial class bdPruebaUserContext : DbContext
    {
        public bdPruebaUserContext()
        {
        }

        public bdPruebaUserContext(DbContextOptions<bdPruebaUserContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> Persons { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=bdPruebaUser;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.24-mariadb"));
            }
        }
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("persons");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.PersonId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PersonID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.Property(e => e.Apellido).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.NombreUser).HasMaxLength(255);

                entity.Property(e => e.PasswordUser)
                    .HasMaxLength(255)
                    .HasColumnName("passwordUser");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usuarios");

                entity.Property(e => e.ApellidoUno)
                    .HasMaxLength(255)
                    .HasColumnName("ApellidoUNO");

                entity.Property(e => e.EmailUsario)
                    .HasMaxLength(255)
                    .HasColumnName("EmailUSARIO");

                entity.Property(e => e.NombreUno)
                    .HasMaxLength(255)
                    .HasColumnName("NombreUNO");

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(255)
                    .HasColumnName("NombreUSUARIO");

                entity.Property(e => e.PasswordUsuariop)
                    .HasMaxLength(255)
                    .HasColumnName("passwordUSUARIOP");

                entity.Property(e => e.UsuariorId).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
