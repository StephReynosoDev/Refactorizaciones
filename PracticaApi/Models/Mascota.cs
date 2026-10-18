namespace PracticaApi.Models
{
    public class Mascota
    {
        public int Id {get; set;}
        public string Nombre {get; set;} = string.Empty;
        public string Raza {get; set;} = string.Empty;
        public string Edad {get; set;} = string.Empty;
    }
}