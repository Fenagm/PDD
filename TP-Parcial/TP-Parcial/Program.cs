using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TP_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Tareas> tareas = new List<Tareas>();
            //tareas.Add(new Tareas("Ejercicio1", new DateTime(2020, 5, 23), 10, new Recursos(), "Realizada", 1));
            //tareas.Add(new Tareas("Ejercicio2", new DateTime(2020, 9, 12), 12, new Recursos(), "Realizada",2));
            //tareas.Add(new Tareas("Ejercicio3", new DateTime(2020, 7, 29), 12, new Recursos(), "Realizada",3));
            //tareas.Add(new Tareas("Ejercicio4", new DateTime(2020, 4, 06), 11, new Recursos(), "Pendiente",4));

            //foreach (Tareas i in tareas)
            {
              //  Console.WriteLine("{0}\t", i.ToString());
            }

            //CreateUser( "marta", "clave1234");
            //UpdateUserName(2, "Fer");
            //UpdateUserName("Juan", "pedro");
            //DeleteUser(2);
            //Console.WriteLine(SelectUser(11));

            //Console.ReadLine();
            //CreateRecurso("recurso uno", 1);
            //CreateRecurso("recurso dos", 1);
            //UpdateRecurso(1, "recurso UNO");
            //DeleteRecurso(1);
            CreateTask("Tarea 1", DateTime.Now, 2,1, "pending");
           Console.WriteLine(SelectTask(2));

            //CreateTask("Tarea 2", DateTime.Now, 2, 1, "pending");
            //UpdateTaskStatus(1,"finalizado");
            //DeleteTask(1);
        }

        // CRUD USUARIOS
        static void CreateUser(string name, string pass) {

            var ctx = new TareasDbcontext();

            ctx.Usuario.Add(new Usuarios
            {
                Usuario = name,
                Clave = pass,
                
            });

            ctx.SaveChanges();
        }
        static void UpdateUserName(int id, string newname)
        {
            
            var ctx = new TareasDbcontext();
            var user = ctx.Usuario.Where(i => i.id == id).FirstOrDefault();

            if(user!= null)
            { user.Usuario = newname; };

            ctx.SaveChanges();
        }
        static void UpdateUserName(string name, string newname)

        {

            var ctx = new TareasDbcontext();
            var user = ctx.Usuario.Where(i => i.Usuario == name).FirstOrDefault();

            if (user != null)
            { user.Usuario = newname; };

            ctx.SaveChanges();
        }
        static void DeleteUser(string name) {

            var ctx = new TareasDbcontext();
            var user = ctx.Usuario.Where(i => i.Usuario == name).Single();
            ctx.Usuario.Remove(user);
            ctx.SaveChanges();
        }
        static void DeleteUser(int id)
        {

            var ctx = new TareasDbcontext();
            var user = ctx.Usuario.Where(i => i.id == id).Single();
            ctx.Usuario.Remove(user);
            ctx.SaveChanges();
        }

        static string SelectUser(int id) {

            var ctx = new TareasDbcontext();
            var user = ctx.Usuario.Where(i => i.id == id).FirstOrDefault();
            if (user != null)
            {
                return user.ToString();
            }
            else { return "no existe"; }
        }

       
        // CRUD TAREAS
        static void CreateTask(string titulo, DateTime vencimiento, int estimacion,int recursosid,  string estado) {

            var ctx = new TareasDbcontext();
            ctx.Tareas.Add(new Tareas
            {
                titulo = titulo,
                vencimiento = vencimiento,
                estimacion = estimacion,
                recursosId = recursosid,
                estado = estado,

            });
            ctx.SaveChanges();
        
        }
        static void UpdateTask(int id, string newtitulo) {

            var ctx = new TareasDbcontext();
            var tarea = ctx.Tareas.Where(i => i.id == id).FirstOrDefault();

            if (tarea != null)
            { tarea.titulo = newtitulo; };

            ctx.SaveChanges();




        }
        static void UpdateTask(int id, DateTime newVto) { 
        
         var ctx = new TareasDbcontext();
            var tarea = ctx.Tareas.Where(i => i.id == id).FirstOrDefault();

            if (tarea != null)
            { tarea.vencimiento = newVto; };

            ctx.SaveChanges();
        }
        static void UpdateTask(int id, int newRecurso)
        {

            var ctx = new TareasDbcontext();
            var tarea = ctx.Tareas.Where(i => i.id == id).FirstOrDefault();

            if (tarea != null)
            { tarea.recursosId = newRecurso; };

            ctx.SaveChanges();
        }
        static void UpdateTaskStatus(int id, string newEstado) {

                var ctx = new TareasDbcontext();
                var tarea = ctx.Tareas.Where(i => i.id == id).FirstOrDefault();

                if (tarea != null)
                { tarea.estado = newEstado; };

                ctx.SaveChanges();
            }
        static void UpdateTaskETA(int id, int newEstimacion)
        {

            var ctx = new TareasDbcontext();
            var tarea = ctx.Tareas.Where(i => i.id == id).FirstOrDefault();

            if (tarea != null)
            { tarea.estimacion = newEstimacion; };

            ctx.SaveChanges();
        }
        static void DeleteTask(int id)
        {

            var ctx = new TareasDbcontext();
            var task = ctx.Tareas.Where(i => i.id == id).Single();
            ctx.Tareas.Remove(task);
            ctx.SaveChanges();
        }

        static string SelectTask(int id)
        {

            var ctx = new TareasDbcontext();
            var tarea = ctx.Tareas.Where(i => i.id == id).FirstOrDefault();
            if (tarea != null)
            {
                return tarea.ToString();
            }
            else { return "no existe"; }
        }


        // CRUD RECURSOS

        static void CreateRecurso(string nombre, int usuariosid)
        {
            var ctx = new TareasDbcontext();
            ctx.Recursos.Add(new Recursos
            {
                
                Nombre = nombre,
                UsuariosId = usuariosid,

            });

            ctx.SaveChanges(); 
           ;
        }
        static void UpdateRecurso(int id, string newName) {

            var ctx = new TareasDbcontext();
            var recurso = ctx.Recursos.Where(i => i.id == id).FirstOrDefault();

            if (recurso != null)
            { recurso.Nombre = newName; };

            ctx.SaveChanges();


        }
        static void UpdateRecurso(int id, int newUsuarioId) {

            var ctx = new TareasDbcontext();
            var recurso = ctx.Recursos.Where(i => i.id == id).FirstOrDefault();

            if (recurso != null)
            { recurso.UsuariosId = newUsuarioId; };

            ctx.SaveChanges();


        }
        static void DeleteRecurso(int id)
        {

            var ctx = new TareasDbcontext();
            var recurso = ctx.Recursos.Where(i => i.id == id).Single();
            ctx.Recursos.Remove(recurso);
            ctx.SaveChanges();
        }
        static string SelectRecurso(int id)
        {

            var ctx = new TareasDbcontext();
            var rec = ctx.Tareas.Where(i => i.id == id).FirstOrDefault();
            if (rec != null)
            {
                return rec.ToString();
            }
            else { return "no existe"; }
        }


        // CRUD DETALLES

        static void CreateDetalle( DateTime fecha, int tiempo, int recursoid, int tareaid)
        {
            var ctx = new TareasDbcontext();
            ctx.Detalles.Add(new Detalles
            {
               
                fecha = fecha,
                tiempo = tiempo,
                recursosId = recursoid,
                tareasId=tareaid,

            }); ;

            ctx.SaveChanges();
            ;
        }
        static void UpdateDetalle(int id, DateTime newFecha)
        {

            var ctx = new TareasDbcontext();
            var detalle = ctx.Detalles.Where(i => i.id == id).FirstOrDefault();

            if (detalle != null)
            { detalle.fecha = newFecha; };

            ctx.SaveChanges();


        }
        static void UpdateDetalle(int id, int newTiempo)
        {

            var ctx = new TareasDbcontext();
            var detalle = ctx.Detalles.Where(i => i.id == id).FirstOrDefault();

            if (detalle != null)
            { detalle.tiempo = newTiempo; };

            ctx.SaveChanges();


        }
        static void DeleteDetalle(int id)
        {

            var ctx = new TareasDbcontext();
            var detalle = ctx.Detalles.Where(i => i.id == id).Single();
            ctx.Detalles.Remove(detalle);
            ctx.SaveChanges();
        }


    }
}
