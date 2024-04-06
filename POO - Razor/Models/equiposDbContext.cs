using Microsoft.EntityFrameworkCore;

namespace POO___Razor.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options) 
        {

        }

        //Modelado de tablas de guía 0.9
        public DbSet<marcas> marcas { get; set; }
        public DbSet<equipos> equipos { get; set; }
        public DbSet<tipo_equipo> tipo_equipo { get; set; }
        public DbSet<estados_equipo> estados_equipo { get; set; }

        //Modelado tablas de guía 0.8
        public DbSet<cursos> cursos { get; set; }   
        public DbSet<usuarios> usuarios { get; set; }
    }
}
