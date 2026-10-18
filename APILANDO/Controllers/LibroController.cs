using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace APILANDO;



    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILibro service;

        public LibroController(ILibro service)
    {
            this.service = service;
    }

        [HttpGet("get-libro")]
        public List<Libro> GetLibros()
    {
        return service.GetLibros();
    }

    }



