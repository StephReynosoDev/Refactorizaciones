namespace Strategy{

public class LabradorStrategy : IPaseo
{
    public void MostrarInfoPaseo()
        {
            Console.WriteLine("\n Este es un Labrador");
            Console.WriteLine("\n Paseo de 40 Minutos");
            Console.WriteLine("\n Tiene un Costo de RD$200");
        }
   

}
}