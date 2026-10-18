namespace Grupo1_Inventario
{
    class BodegaCentralXML
    {
        public string ConsultarInventarioXML(string sku)
        {
            Console.WriteLine($"[BodegaCentralXML] Consultando SKU {sku}");
            return $"<inventario><sku>{sku}</sku><cantidad>87</cantidad></inventario>";
        }
    }
}
