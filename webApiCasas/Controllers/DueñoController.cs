using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webApiCasas.Entidades;

namespace webApiCasas.Controllers
{

    [ApiController]
    [Route("Dueño")]

    public class DueñoController: ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public DueñoController(ApplicationDbContext context)
        {

            _context = context;

        }

        [HttpGet]

        public async Task<ActionResult<List<Dueño>>> GetAll()
        {

            return await _context.Dueños.ToListAsync();

        }

        [HttpGet("{id:int}")]

        public async Task<ActionResult<Dueño>> GetById(int id)
        {

            return await _context.Dueños.FirstOrDefaultAsync(x => x.Id == id);

        }

        [HttpPost]

        public async Task<ActionResult> Post(Dueño dueño)
        {

            _context.Add(dueño);
            await _context.SaveChangesAsync();
            return Ok();

        }


        [HttpPut("{id:int}")]

        public async Task<ActionResult> Put(Dueño dueño, int id)
        {

            if (dueño.Id != id)
            {

                return BadRequest("El id de la casa no coincide con el establecido en la url");

            }

            _context.Update(dueño);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {

            var exist = await _context.Dueños.AnyAsync(x => x.Id == id);

            if (!exist)
            {

                return NotFound("No se encontro el registro en la base de datos");

            }

            _context.Remove(new Dueño()
            {

                Id = id

            });
            await _context.SaveChangesAsync();
            return Ok();

        }

    }
}
