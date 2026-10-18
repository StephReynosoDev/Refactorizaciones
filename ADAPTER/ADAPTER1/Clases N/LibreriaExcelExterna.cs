// Incompatibilidad de firma: nombre distinto y parámetros en orden invertido
public class LibreriaExcelExterna
{
    public bool CrearHojaCalculo(string nombreArchivo, string datos)
    {
        Console.WriteLine($"[LibreriaExcelExterna] Creando hoja: {nombreArchivo}");
        Console.WriteLine($"[LibreriaExcelExterna] Datos volcados: {datos}");
        return true;
    }
}
