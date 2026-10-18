using Microsoft.EntityFrameworkCore;
using PracticaApi.Models;

namespace PracticaApi.Context
{
    public class PracticaContext : DbContext
    {
        
        public PracticaContext(DbContextOptions<PracticaContext> options) : base(options)
        {
            
        }

        public DbSet<DatosPersonales> DatosPersonales {get; set;}
        public DbSet<Mascota> Mascotas {get; set;}
    }
}