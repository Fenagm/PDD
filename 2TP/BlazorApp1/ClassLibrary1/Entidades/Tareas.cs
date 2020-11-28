using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1.Entidades
{
    public class Tareas
    {
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }

        public int RecursoId { get; set; }
        public Recursos Responsable { get; set; }
        public string Estado { get; set; }
        public int Id { get; set; }


        public Tareas(string titulo, DateTime vencimiento, int estimacion, Recursos Responsable, string estado)
        {
          
            this.Titulo = titulo;
            this.Vencimiento = vencimiento;
            this.Estimacion = estimacion;
            this.Responsable = Responsable;
            this.Estado = estado;
        }

    }
}
