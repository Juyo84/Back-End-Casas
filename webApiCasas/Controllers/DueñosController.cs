using Microsoft.AspNetCore.Mvc;
using webApiCasas.Entidades;

namespace webApiCasas.Controllers
{

    [ApiController]
    [Route("api/Dueños")]

    public class DueñosController: ControllerBase
    {

        [HttpGet]

        public ActionResult<List<Dueño>> Get()
        {

            return new List<Dueño>(){

                new Dueño() { Id = 1, Nombre = "Julio", Apellido = "Luevano", Edad = 19},
                new Dueño() { Id = 2, Nombre = "Nombre", Apellido = "Apellido", Edad = 20}

            };

        }

    }
}
