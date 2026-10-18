namespace Grupo1_Inventario
{
    class InventarioLocal
    {
        public int ConsultarStock(string codigoProducto)
        {
            Console.WriteLine($"[InventarioLocal] Consultando stock de {codigoProducto}");
            return 42;
        }
    }
}
