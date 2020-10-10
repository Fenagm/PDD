namespace TP_Parcial
{
    public class Recursos
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public int UsuariosId { get; set; }
        public Usuarios Usuario { get; set; }

        public override string ToString()
        {
            return "id:" + id + " " + "Recurso: " + Nombre + " " + "Usuario id:" + UsuariosId;
        }
    }
}
