namespace Practica2
{
    public abstract class Productos{
    //public interface IProductos{}
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public TipoProducto Tipo { get; set; }

        public abstract void MostrarDetalles();
}
}