using Microsoft.AspNetCore.Http.HttpResults;

namespace Practica4_APIS;
public class PedidoService : IPedido
{
    
    public List<Pedido> GetPedidos()
    
    {
        
        List<Pedido> listaPedidos = new List<Pedido>();
        listaPedidos.Add(new Pedido
        {
            Producto = "Maquina de Imprension 3D",

            Cantidad = 5,

            Precio = 120000

            
        });
        listaPedidos.Add(new Pedido
        {
            Producto = "Telefono Xiaomi Para CODM",

            Cantidad = 9,

            Precio = 50500
        });
        listaPedidos.Add(new Pedido
        {
            Producto = "Asus Gamer HP Dura",

            Cantidad = 21,

            Precio = 150000
        });

         if (!listaPedidos.Any())
            return null;
           
           else 
            return listaPedidos;

    }


    // se coloca aqui para que no de el error de la interface, dure 2 horas en eso
     public void Agregar(Pedido pedido) { }
     public Cotizacion CotizarPedido(Pedido pedido)
    {
       
        decimal subtotal = pedido.Cantidad * pedido.Precio;
        decimal descuento = subtotal > 1000 ? subtotal * 0.10m : 0;
        decimal base_ = subtotal - descuento;
        decimal impuesto = base_ * 0.18m;
        decimal total = base_ + impuesto;

        return new Cotizacion
        {
            Subtotal = Math.Round(subtotal, 2),
            Descuento = Math.Round(descuento, 2),
            Impuesto = Math.Round(impuesto, 2),
            Total = Math.Round(total, 2)
        };
  
}
}
