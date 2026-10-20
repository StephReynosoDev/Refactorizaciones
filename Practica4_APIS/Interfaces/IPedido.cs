namespace Practica4_APIS;

public interface IPedido
{
    List<Pedido> GetPedidos();
    void Agregar(Pedido pedido);
    Cotizacion CotizarPedido(Pedido pedido);
}