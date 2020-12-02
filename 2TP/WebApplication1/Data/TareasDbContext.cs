using Microsoft.EntityFrameworkCore;
using ClassLibrary1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace WebApplication1.Data
{
    public class TareasDbContext: DbContext  
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(user =>
            {
                user.ToTable("Usuarios");
                user.HasKey(p => p.UsuarioPK);
                user.Property(p => p.UsuarioPK).ValueGeneratedOnAdd().HasColumnName("Id");
                user.Property(p => p.Nombre).HasColumnName("Usuario").HasColumnType("varchar(50)").IsRequired();
                user.Property(p => p.Clave).HasColumnName("Clave").HasColumnType("varchar(12)").IsRequired();
            });


            modelBuilder.Entity<Recurso>(rec =>
            {
                rec.ToTable("Recursos");
                rec.HasKey(p => p.Id);
                rec.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                rec.Property(p => p.Nombre).HasColumnName("Nombre").HasColumnType("varchar(50)").IsRequired();
            });

            modelBuilder.Entity<Tarea>(tar =>
            {
                tar.ToTable("Tareas");
                tar.HasKey(p => p.Id);
                tar.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                tar.Property(p => p.Titulo).HasColumnName("titulo").HasColumnType("varchar(50)").IsRequired();
                tar.Property(p => p.Vencimiento).HasColumnName("vencimiento").IsRequired();
                tar.Property(p => p.Estimacion).HasColumnName("estimacion").HasColumnType("int(2)").IsRequired();
                tar.Property(p => p.Estado).HasColumnName("estado").HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<Detalle>(det =>
            {
                det.ToTable("Detalles");
                det.HasKey(p => p.Id);
                det.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                det.Property(p => p.Fecha).HasColumnName("fecha").IsRequired();
                det.Property(p => p.Tiempo).HasColumnName("tiempo").HasColumnType("int(5)").IsRequired();
            });
        }

        internal object AsNoTracking()
        {
            throw new NotImplementedException();
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Detalle> Detalles { get; set; }

    }
}
