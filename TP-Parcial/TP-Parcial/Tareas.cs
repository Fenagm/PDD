using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Parcial
{
    public class Tareas
    {
        public string titulo { get; set; }
        public DateTime vencimiento { get; set; }
        public int estimacion { get; set; }

        public int recursosId { get; set; }
        public Recursos responsable { get; set; }
        public string estado { get; set; }
        public int id { get; set; }


        public Tareas(string titulo, DateTime vencimiento, int estimacion, Recursos responsable, string estado, int id)
        {
            this.titulo = titulo;
            this.vencimiento = vencimiento;
            this.estimacion = estimacion;
            this.responsable = responsable;
            this.estado = estado;
        }

        public Tareas() { }
    }
}

