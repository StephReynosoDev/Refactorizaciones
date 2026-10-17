namespace Practica3
{
    
    public class EmpleadoContext
    {
        private ICalculo _calculo;
        public int SalarioBase {get; set;}
        public int PagoPorHora {get; set;}
        public double Comision {get; set;}

        public EmpleadoContext(ICalculo calculo, int SalarioBase, int PagoPorHora, double Comision)
        {
            _calculo = calculo;
        
            this.SalarioBase = SalarioBase;
            this.PagoPorHora = PagoPorHora;
            this.Comision = Comision;

        }

        public void EjecutarCalculo()
        {
            _calculo.CalcularComision(this);
        }
        
    }
}