public class RelojDigital
{
    public string ObtenerHoraActual()
    {
        return DateTime.Now.ToString("HH:mm:ss");
    }
}