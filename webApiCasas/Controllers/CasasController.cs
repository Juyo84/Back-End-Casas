using Microsoft.AspNetCore.Mvc;
using webApiCasas.Entidades;

namespace webApiCasas.Controllers
{
    [ApiController]
    [Route("api/Casas")]

    public class CasasController : ControllerBase
    {
        [HttpGet]

        public ActionResult<List<Casa>> Get()
        {

            return new List<Casa>(){

                new Casa() { Id = 1, Direccion = "Independencia y mas", Precio = 2999999.99f},
                new Casa() { Id = 2, Direccion = "Uni", Precio = 1f}

            };

        }

    }
}
