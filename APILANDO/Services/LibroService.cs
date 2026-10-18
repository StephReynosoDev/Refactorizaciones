namespace APILANDO;

public class LibroService : ILibro
{
    public List<Libro> GetLibros()
    {
        List<Libro> listaLibros = new List<Libro>();
        listaLibros.Add(new Libro
        {   
            Id = 1,
            Titulo = "a",
            Autor = "mm",
            AnoCreacion = 1990
        });
        listaLibros.Add(new Libro
        {   
            Id = 2,
            Titulo = "e",
            Autor = "uu",
            AnoCreacion = 1999
        });
        listaLibros.Add(new Libro
        {   
            Id = 3,
            Titulo = "i",
            Autor = "cc",
            AnoCreacion = 1995
        });
        listaLibros.Add(new Libro
        {   
            Id = 4,
            Titulo = "o",
            Autor = "tt",
            AnoCreacion = 1991
        });

        if(!listaLibros.Any())
        return null;

        else
        return listaLibros;
    }
}