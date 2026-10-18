


namespace Grupo1_Inventario
{
public class BodegaXMLAdapter : IGestorInventario
{
    private BodegaCentralXML _bodegaCentralXML;

    internal BodegaXMLAdapter(BodegaCentralXML bodegaCentralXML)
    {
        _bodegaCentralXML = bodegaCentralXML;
    }

            public int ConsultarInventario(string sku)
{
            string var1 = _bodegaCentralXML.ConsultarInventarioXML(sku);

        
            string[] modificador = { "<cantidad>", "</cantidad>" };
            string[] var2 = var1.Split(modificador, StringSplitOptions.None);
            string cantidad = var2[1];
            return int.Parse(cantidad);

}

}
        
}
