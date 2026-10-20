namespace Strategy2
{
    
    public class ImpuestoMedio : IImpuestos
    {
        public double CalcularImpuestos(double Salario)
        {
            return Salario * 0.10;
        }
    }
}