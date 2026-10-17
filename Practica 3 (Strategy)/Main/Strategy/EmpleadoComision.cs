namespace Practica3
{
    public class EmpleadoComision : ICalculo
    {

        public void CalcularComision(EmpleadoContext empleado){
          
            double baseSueldo = double.Parse(Console.ReadLine() ?? "0");
            
          
            double ventas = double.Parse(Console.ReadLine() ?? "0");
            
            
            double comision = double.Parse(Console.ReadLine() ?? "0");
            
            Console.WriteLine($"\nSalario calculado: {baseSueldo + (ventas * (comision / 100))}");
    }
}
}
    