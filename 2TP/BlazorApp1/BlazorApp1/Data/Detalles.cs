using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Data
{
    public class Detalles
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Tiempo { get; set; }
        public int RecursosId { get; set; }
        public Recursos Recurso { get; set; }
        public int TareasId { get; set; }
        public Tareas Tarea { get; set; }



    }
}
