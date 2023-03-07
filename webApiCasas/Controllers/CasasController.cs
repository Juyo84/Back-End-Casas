using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webApiCasas.Entidades;

namespace webApiCasas.Controllers
{
    [ApiController]
    [Route("Casa")]

    public class CasasController : ControllerBase
    {

        private readonly ApplicationDbContext dbContext;

        public CasasController(ApplicationDbContext context){
        
            this.dbContext = context;
        
        }

        [HttpGet]

        public ActionResult<List<Casa>> Get()
        {

            return new List<Casa>(){

                new Casa() { Id = 1, Direccion = "Independencia y mas", Precio = 2999999.99f},
                new Casa() { Id = 2, Direccion = "Uni", Precio = 1f}

            };

        }

        [HttpPost]

        public async Task<ActionResult> Post(Casa casa)
        {

            var existeDueño = await dbContext.Dueños.AnyAsync(c => c.Id == casa.DueñoID);

            if (!existeDueño)
            {

                return BadRequest("No existe el dueño");

            }

            dbContext.Add(casa);
            await dbContext.SaveChangesAsync();
            return Ok();

        }

        [HttpGet("/Lista")]

        public async Task<ActionResult<List<Casa>>> GetAll()
        {

            return await dbContext.Casas.Include(x => x.Dueño).ToListAsync();

        }

        [HttpPut("{id:int}")]

        public async Task<ActionResult> Put(Casa casa, int id)
        {

            if (casa.Id != id) {

                return BadRequest("El id de la casa no coincide con el establecido en la url");

            }

            var existeDueño = await dbContext.Dueños.AnyAsync(c => c.Id == casa.DueñoID);

            if (!existeDueño)
            {

                return BadRequest("No existe el dueño");

            }

            dbContext.Update(casa);
            await dbContext.SaveChangesAsync();
            return Ok();

        }

        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {

            var exist = await dbContext.Casas.AnyAsync(x => x.Id == id);

            if (!exist) {
            
                return NotFound("No se encontro el registro en la base de datos");
            
            }

            dbContext.Remove(new Casa()
            {

                Id = id

            });
            await dbContext.SaveChangesAsync();
            return Ok();

        }

    }
}
