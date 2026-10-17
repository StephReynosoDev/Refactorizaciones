namespace Practica2
{
    public class RopaProducto : Productos
    {

        public string Tallas { get; set; }
        public override void MostrarDetalles()
        {
                Console.WriteLine($"\nProducto: {Nombre} (${Precio})");



                Console.WriteLine($"Tallas: {Tallas}");
        }
       

        }
        }

          
        

        
            
        
     


    
        
    
