using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
 

namespace ClassLibrary1.Entidades
{
    public class Recursos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int UsuariosId { get; set; }
        public Usuarios Usuario { get; set; }

     }
}