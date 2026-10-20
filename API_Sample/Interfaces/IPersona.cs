using System.Collections.Generic;


namespace API_Sample.Interfaces;

public interface IPersona
{
    List<Persona> GetPersonas();
    void Agregar(Pedido pedido);
    Cotizacion CotizarPedido(Pedido pedido);
}
