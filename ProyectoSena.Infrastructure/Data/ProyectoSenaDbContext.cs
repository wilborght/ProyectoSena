﻿using Microsoft.EntityFrameworkCore;
using ProyectoSena.Core.Domain;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoSena.Core
{
    public partial class ProyectoSenaDbContext : DbContext
    {
        public ProyectoSenaDbContext()
        {
        }

        public ProyectoSenaDbContext(DbContextOptions<ProyectoSenaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<RegistroIngreso> RegistroIngreso { get; set; }
        public virtual DbSet<Solicitud> Solicitud { get; set; }
        public virtual DbSet<Suministro> Suministro { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("database=recursoshumanos;server=localhost;port=3306;user id=root", x => x.ServerVersion("10.4.18-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PRIMARY");

                entity.ToTable("estado");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.NombreEstado)
                    .HasColumnName("Nombre_Estado")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.HasKey(e => e.IdHorario)
                    .HasName("PRIMARY");

                entity.ToTable("horario");

                entity.Property(e => e.IdHorario)
                    .HasColumnName("Id_Horario")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FranjaHoraria)
                    .HasColumnName("Franja_Horaria")
                    .HasColumnType("date");

                entity.Property(e => e.NombreHorario)
                    .HasColumnName("Nombre_Horario")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PRIMARY");

                entity.ToTable("producto");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("Id_Producto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CantidadDisponible)
                    .HasColumnName("Cantidad_Disponible")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSuministro)
                    .HasColumnName("Id_Suministro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Medidas)
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NombreProducto)
                    .HasColumnName("Nombre_Producto")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<RegistroIngreso>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PRIMARY");

                entity.ToTable("registro_ingreso");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("Id_Registro")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaEntrada)
                    .HasColumnName("Fecha_Entrada")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("Fecha_Ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdHorario)
                    .HasColumnName("Id_Horario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("Id_Usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreRegistro)
                    .HasColumnName("Nombre_Registro")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Solicitud>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud)
                    .HasName("PRIMARY");

                entity.ToTable("solicitud");

                entity.Property(e => e.IdSolicitud)
                    .HasColumnName("Id_Solicitud")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaCreada)
                    .HasColumnName("Fecha_Creada")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRespuesta)
                    .HasColumnName("Fecha_Respuesta")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("Id_Usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreSolicitud)
                    .HasColumnName("Nombre_Solicitud")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Suministro>(entity =>
            {
                entity.HasKey(e => e.IdSuministro)
                    .HasName("PRIMARY");

                entity.ToTable("suministro");

                entity.Property(e => e.IdSuministro)
                    .HasColumnName("Id_Suministro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSolicitud)
                    .HasColumnName("Id_Solicitud")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreSuministro)
                    .HasColumnName("Nombre_Suministro")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("Id_Usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Direccion)
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdHorario)
                    .HasColumnName("Id_Horario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSolicitud)
                    .HasColumnName("Id_Solicitud")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NDocumento)
                    .HasColumnName("N_Documento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("Primer_Apellido")
                    .HasColumnType("varchar(14)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("Primer_Nombre")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("Segundo_Apellido")
                    .HasColumnType("varchar(14)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("Segundo_Nombre")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
