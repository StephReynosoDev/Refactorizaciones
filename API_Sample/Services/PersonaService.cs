
namespace API_Sample.Interfaces;


public class PersonaService : IPersona
{
    public List<Persona> GetPersonas()
    {
        List<Persona> listaPersonas = new List<Persona>();
            listaPersonas.Add(new Persona
            {
                Nombre = "Steph",
                Correo = "St@gmail.com"
            });
              listaPersonas.Add(new Persona
            {
                Nombre = "Franklin",
                Correo = "Ft@gmail.com"
            });
              listaPersonas.Add(new Persona
            {
                Nombre = "Sbasteph",
                Correo = "Sb@gmail.com"
            });
                
            
            if (!listaPersonas.Any())
            return null;
           
           else 
            return listaPersonas;
    }
}