public class RelojDigitalAdapter : IReloj
{
    private RelojDigital _relojDigital;

    public RelojDigitalAdapter(RelojDigital relojDigital)
    {
        _relojDigital = relojDigital;
    }

    public string ObtenerHoraActual()
    {
        return _relojDigital.ObtenerHoraActual();
    }
}