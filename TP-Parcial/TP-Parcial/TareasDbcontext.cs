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
                ;

            modelBuilder.Entity<Detalles>()
                    .ToTable("Detalles")                                     
                ;


            modelBuilder.Entity<Recursos>()
                    .ToTable("Recursos")
                 ;

            modelBuilder.Entity<Tareas>()             
                    .ToTable("Tareas")
                ;


         }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Detalles> Detalles { get; set; }
        public DbSet<Recursos> Recursos { get; set; }
        public DbSet<Tareas> Tareas { get; set; }





    }
}
