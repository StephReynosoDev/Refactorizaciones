public class RelojAnalogicoAdapter : IReloj
{
    private RelojAnalogico _relojAnalogico;

    public RelojAnalogicoAdapter(RelojAnalogico relojAnalogico)
    {
        _relojAnalogico = relojAnalogico;
    }

    public string ObtenerHoraActual()
    {

        return $"{ _relojAnalogico.ObtenerHora():D2}: {_relojAnalogico.ObtenerMinutos():D2}: {_relojAnalogico.ObtenerSegundos():D2}";
    }
}
