using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refit;

namespace BlazorApp1.Data
{
    public class DetallesService
    {
        
        private TareasDbcontext ctx;

        public DetallesService(TareasDbcontext _context)
        {
            ctx = _context;
        }

        public async Task<List<Detalles>> ListDetail()
        {
            //return await ctx.Detalles.Include(i => i.Recurso).Include(i => i.Tarea).ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44381/api/");
            return await remoteService.GetAllDetalle();
        }

        public async Task<Detalles> SelectDetail(int id)
        {
            //return await ctx.Detalles.Where(i => i.Id == id).SingleAsync();
  var remoteService = RestService.For<IRemoteService>("https://localhost:44381/api/");
            return await remoteService.GetDetalle(id);
        }

        public async Task<Detalles> SaveDetail(Detalles value)
        {
      var remoteService = RestService.For<IRemoteService>("https://localhost:44381/api/");
            return await remoteService.GuardarDetalle(value);
        }

        public async Task<bool> DeleteDetail(int id)
        {
           var remoteService = RestService.For<IRemoteService>("https://localhost:44381/api/");
            await remoteService.BorrarDetalle(id);
            return true;
        

      
        }
    }
}
