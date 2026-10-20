

namespace Strategy{

public class Paseador 
{
   private IPaseo _strategy;

    public Paseador(IPaseo strategy)
        {
            _strategy = strategy;
        }



    public void EjecutarPaseo()
        {
            _strategy.MostrarInfoPaseo();
        }

}
}
