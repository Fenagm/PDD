using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TP_Parcial
{
    public class TareasDbcontext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            optionsBuilder.UseSqlite("Data Source=tareas.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Usuarios>()
                    .ToTable("Usuario")
                    .Property(p=>p.Clave)
                    .HasMaxLength(20)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                ;

            modelBuilder.Entity<Usuarios>()
                .ToTable("Usuario")
                .Property(p => p.Usuario)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnType("varchar(50)")
            ;

            modelBuilder.Entity<Detalles>()
                    .ToTable("Detalles")
                    .Property(p=> p.fecha)
                    .HasColumnType("DateTime")
                    .IsRequired()
                ;
            modelBuilder.Entity<Detalles>()
                   .ToTable("Detalles")
                   .Property(p => p.tiempo)
                   .HasColumnType("int")
                   .IsRequired()
               ;
            modelBuilder.Entity<Detalles>()
                   .ToTable("Detalles")
                   .Property(p => p.recursosId)
                   .HasColumnType("int")
                   .IsRequired()
               ;
            modelBuilder.Entity<Detalles>()
                   .ToTable("Detalles")
                   .Property(p => p.tareasId)
                   .HasColumnType("int")
                   .IsRequired()
               ;

            modelBuilder.Entity<Recursos>()
                    .ToTable("Recursos")
                    .Property(p=>p.id)
                    .HasColumnType("int")
                    .IsRequired()
                    .HasMaxLength(100)
                 ;
            modelBuilder.Entity<Recursos>()
                  .ToTable("Recursos")
                  .Property(p => p.Nombre)
                  .HasColumnType("varchar(100)")
                  .IsRequired()
                  .HasMaxLength(100)
               ;
            modelBuilder.Entity<Recursos>()
                  .ToTable("Recursos")
                  .Property(p => p.UsuariosId)
                  .HasColumnType("int")
                  .IsRequired()
                  .HasMaxLength(100)
               ;
            modelBuilder.Entity<Tareas>()             
                    .ToTable("Tareas")
                    .Property(p=>p.titulo)
                    .HasColumnType("varchar(100)")
                    .IsRequired()
                    .HasMaxLength(100)
            ;

            modelBuilder.Entity<Tareas>()
                    .ToTable("Tareas")
                    .Property(p => p.vencimiento)
                    .HasColumnType("DateTime")
                    .IsRequired()
                    .HasMaxLength(50)
            ;
            modelBuilder.Entity<Tareas>()
                    .ToTable("Tareas")
                    .Property(p => p.estimacion)
                    .HasColumnType("int")
                    .IsRequired()
                    .HasMaxLength(100)
                    
            ;
            modelBuilder.Entity<Tareas>()
                    .ToTable("Tareas")
                    .Property(p => p.recursosId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("int")
            ;
            modelBuilder.Entity<Tareas>()
                    .ToTable("Tareas")
                    .Property(p => p.estado)
                    .HasColumnType("varchar(100)")
                    .IsRequired()
                    .HasMaxLength(100)
                    
            ;
        }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Detalles> Detalles { get; set; }
        public DbSet<Recursos> Recursos { get; set; }
        public DbSet<Tareas> Tareas { get; set; }





    }
}
