namespace Strategy2
{
    public class EmpleadoContext
    {

        private IImpuestos _descontar;
        public string Nombre {get; set;}
        public double Salario {get; set;}
        public double Impuesto {get; set;}
        public TipoEmpleado TipoEmpleados {get; set;}


        public EmpleadoContext(IImpuestos descontar, string Nombre, double Salario, TipoEmpleado TipoEmpleados)
        {
            _descontar = descontar;
            this.Nombre = Nombre;
            this.Salario = Salario;
            this.Impuesto = Impuesto;
            this.TipoEmpleados = TipoEmpleados;
        }

        public void EjecutarImpuestos()
        {
            Impuesto =  _descontar.CalcularImpuestos(Salario);
        }
    }
}