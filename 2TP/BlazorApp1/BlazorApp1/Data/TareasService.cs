using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refit;

namespace BlazorApp1.Data
{
    public class TareasService
    {


        public async Task<List<Tareas>> ListTask()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44381/api/");
            return await remoteService.GetAllTarea();
        }

        public async Task<Tareas> SelectTask(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44381/api/");
            return await remoteService.GetTarea(id);
        }

        public async Task<Tareas> SaveTask(Tareas value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44381/api/");
            return await remoteService.GuardarTarea(value);
        }

        public async Task<bool> DeleteTask(int id)
        {
             var remoteService = RestService.For<IRemoteService>("https://localhost:44381/api/");
            await remoteService.BorrarTarea(id);
            return true;
        }

        
    }
}
