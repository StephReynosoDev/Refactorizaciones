using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Practica4_APIS;



    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedido service;

        public PedidoController(IPedido service)
    {
        this.service = service;
    }

          [HttpGet("get-pedido")]
        public List<Pedido> GetPedidos()
    {
        return service.GetPedidos();

    }
   [HttpPost("cotizar")]
    public IActionResult Cotizar([FromBody] Pedido pedido)
    {
        if (string.IsNullOrEmpty(pedido.Producto) || pedido.Cantidad <= 0 || pedido.Precio <= 0)
            return BadRequest("datos invalidos manito.");

        return Ok(service.CotizarPedido(pedido));
    }
}

