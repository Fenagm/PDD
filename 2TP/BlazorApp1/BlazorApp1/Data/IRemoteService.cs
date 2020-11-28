using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;
namespace BlazorApp1.Data
{
    interface IRemoteService
    {
        [Get("/Tareas")]
        Task<List<Tareas>> GetAllTarea();

	[Get("/Tareas/{id}")]
        Task<Tareas> GetTarea(int id);

        [Post("/Tareas")]
        Task<Tareas> GuardarTarea(Tareas valor);
	
	[Delete("/Tareas/{id}")]
        Task<Tareas> BorrarTarea(int id);

        
        [Get("/Usuarios")]
        Task<List<Usuarios>> GetAllUsuario();

     
    	 [Get("/Usuarios/{id}")]
        Task<Usuarios> GetUsuario(int id);

        
        [Post("/Usuarios")]
        Task<Usuarios> GuardarUsuario(Usuarios valor);

        [Delete("/Usuarios/{id}")]
        Task<Usuarios> BorrarUsuario(int id);

        
        [Get("/Detalles")]
        Task<List<Detalles>> GetAllDetalle();

        [Get("/Detalles/{id}")]
        Task<Detalles> GetDetalle(int id);

        [Post("/Detalles")]
        Task<Detalles> GuardarDetalle(Detalles valor);

        [Delete("/Detalles/{id}")]
        Task<Detalles> BorrarDetalle(int id);

        [Get("/Recursos")]
        Task<List<Recursos>> GetAllRecurso();

        [Get("/Recursos/{id}")]
        Task<Recursos> GetRecurso(int id);

        [Post("/Recursos")]
        Task<Recursos> GuardarRecurso(Recursos valor);

        [Delete("/Recursos/{id}")]
        Task<Recursos> BorrarRecurso(int id);
    }
}
