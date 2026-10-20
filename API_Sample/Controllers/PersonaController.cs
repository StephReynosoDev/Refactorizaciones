using API_Sample;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace API_Sample.Interfaces;



    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        // segundo paso crear un objeto de tipo de la interfaz
        private readonly IPersona service;
        // tercer paso crear un constructor para inyectar service

        public PersonaController(IPersona service)
    {
        this.service = service;
    }


                //5 paso dar rutas
    
        [HttpGet("get-personas")]
        //si usamos IActionResult tenemos que crear un metodo para que pueda retornar si no dara error
        //ejemplo return Ok(listaPersonas);
            public /*IActionResult*/ List<Persona> GetPersonas()
        {

            // cuarto paso
            return service.GetPersonas();




            /*return null;*/





            /*if (!listaPersonas.Any())
                return NoContent;
              else
                return Ok(ListaPersonas);  */
        }
    }
  

