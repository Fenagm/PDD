using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.Entidades;
using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public UsuariosController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuarios>>> Get()
        {
            return await _context.Usuarios.AsNoTracking().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuarios>> GetUser(int id)
        {
            return await _context.Usuarios.Where(i => i.Id== id).AsNoTracking().SingleAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Usuarios>> Post(Usuarios valor)
        {
           

            if (valor.Id == 0)
            {
                _context.Usuarios.Add(valor);
            }
            else
            {
                _context.Entry(valor).State = EntityState.Unchanged;
                _context.Entry(valor).State = EntityState.Modified;
               
            }
                await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = _context.Usuarios.Where(i => i.Id== id).Single();

            _context.Usuarios.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

       
    }
}
