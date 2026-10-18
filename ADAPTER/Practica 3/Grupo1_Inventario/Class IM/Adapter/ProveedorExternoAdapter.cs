namespace Grupo1_Inventario
{

public class ProveedorExternoAdapter : IGestorInventario
{
    private ProveedorExternoStock _proveedorExternoStock;

    internal ProveedorExternoAdapter(ProveedorExternoStock proveedorExternoStock)
        {
            _proveedorExternoStock = proveedorExternoStock;
        }

    public int ConsultarInventario(string sku)
        {
            _proveedorExternoStock.Conectar();
            int stock = _proveedorExternoStock.ObtenerCantidad(sku);
            _proveedorExternoStock.Desconectar();
            return stock;
        }
}
}