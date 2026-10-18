namespace Grupo1_Inventario{
    

    public class InventarioLocalAdapter : IGestorInventario
    {
        private InventarioLocal _inventarioLocal;

        internal InventarioLocalAdapter(InventarioLocal inventarioLocal)
        {
            _inventarioLocal = inventarioLocal;
        }

        public int ConsultarInventario(string sku)
        {
            return _inventarioLocal.ConsultarStock(sku);
        }
    }
}