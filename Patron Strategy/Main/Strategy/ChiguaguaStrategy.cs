namespace Strategy{

public class ChiguaguaStrategy : IPaseo
{
    public void MostrarInfoPaseo()
        {
            Console.WriteLine("\n Este es un Chiguagua");
            Console.WriteLine("\n Paseo de 20 Minutos");
            Console.WriteLine("\n Tiene un Costo de RD$100");
        }
}
}