namespace Grupo1_Inventario
{
    class Cliente 
    {

     private IGestorInventario _adaptadorInventario;


     public Cliente (IGestorInventario adaptadorInventario)
        {
            _adaptadorInventario =  adaptadorInventario;
        }       

         public void ConsultarProducto(string codigoProducto)
        {
            int stock = _adaptadorInventario.ConsultarInventario(codigoProducto);
            Console.WriteLine($"[Cliente] Stock disponible: {stock}");
        }
    }
}
        /*private InventarioLocal _inventario = new InventarioLocal();

        public void ConsultarProducto(string codigoProducto)
        {
            int stock = _inventario.ConsultarStock(codigoProducto);
            Console.WriteLine($"[Cliente] Stock disponible: {stock}");
        }
    }
}
*/