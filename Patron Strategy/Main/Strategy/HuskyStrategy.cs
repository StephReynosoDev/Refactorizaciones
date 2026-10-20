namespace Strategy{


public class HuskyStrategy : IPaseo
{
    public void MostrarInfoPaseo()
        {
            Console.WriteLine("\n Este es un Husky Siberiano");
            Console.WriteLine("\n Paseo de 60 Minutos");
            Console.WriteLine("\n Tiene un Costo de RD$300");
        }
    
}
}