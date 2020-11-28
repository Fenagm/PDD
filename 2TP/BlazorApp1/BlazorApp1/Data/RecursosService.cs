using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refit;

namespace BlazorApp1.Data
{
    public class RecursosService
    {
        
       
        public async Task<List<Recursos>> ListResource()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44381/api/");
            return await remoteService.GetAllRecurso();
        }

        public async Task<Recursos> SelectResource(int id)
        {
             var remoteService = RestService.For<IRemoteService>("https://localhost:44381/api/");
            return await remoteService.GetRecurso(id);
        }

        public async Task<Recursos> SaveResource(Recursos value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44381/api/");
            return await remoteService.GuardarRecurso(value);
        }

        public async Task<bool> DeleteResource(int id)
        {
           var remoteService = RestService.For<IRemoteService>("https://localhost:44381/api/");
            await remoteService.BorrarRecurso(id);
            return true;

        
        }

    }
}
