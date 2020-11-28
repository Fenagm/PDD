using Microsoft.EntityFrameworkCore;
using ClassLibrary1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace BlazorApp1.Data
{
    public class TareasDbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>(user =>
            {
                user.ToTable("Usuarios");
                user.HasKey(p => p.Id);
                user.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                user.Property(p => p.Usuario).HasColumnName("Usuario").HasColumnType("varchar(50)").IsRequired();
                user.Property(p => p.Clave).HasColumnName("Clave").HasColumnType("varchar(12)").IsRequired();
            });


            modelBuilder.Entity<Recursos>(rec =>
            {
                rec.ToTable("Recursos");
                rec.HasKey(p => p.Id);
                rec.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                rec.Property(p => p.Nombre).HasColumnName("Nombre").HasColumnType("varchar(50)").IsRequired();
                rec.Property(p => p.UsuariosId).HasColumnName("UsuariosId").HasColumnType("int").IsRequired();
            });

            modelBuilder.Entity<Tareas>(tar =>
            {
                tar.ToTable("Tareas");
                tar.HasKey(p => p.Id);
                tar.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                tar.Property(p => p.Titulo).HasColumnName("Titulo").HasColumnType("varchar(50)").IsRequired();
                tar.Property(p => p.Vencimiento).HasColumnName("Vencimiento").IsRequired();
                tar.Property(p => p.Estimacion).HasColumnName("Estimacion").HasColumnType("int(2)").IsRequired();
                tar.Property(p => p.Estado).HasColumnName("Estado").HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<Detalles>(det =>
            {
                det.ToTable("Detalles");
                det.HasKey(p => p.Id);
                det.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                det.Property(p => p.Fecha).HasColumnName("Fecha").IsRequired();
                det.Property(p => p.Tiempo).HasColumnName("Tiempo").HasColumnType("int(5)").IsRequired();
            });
        }

        internal object AsNoTracking()
        {
            throw new NotImplementedException();
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Recursos> Recursos { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Detalles> Detalles { get; set; }

    }
}
