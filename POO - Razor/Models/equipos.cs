using System.ComponentModel.DataAnnotations;
namespace POO___Razor.Models
{
    //Modelado de las tablas del formulario de la guía 0.9
    public class equipos
    {
        [Key]

        public int id_equipos { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int? id_tipo_equipo { get; set; }
        public int? id_marca { get; set; }
        public string modelo { get; set; }
        public int? anio_compra { get; set; }
        public decimal costo { get; set; }
        public int? vida_util { get; set; }
        public int? id_estados_equipo { get; set; }
        public string estado { get; set; }
    }

    public class marcas
    {
        [Key]
        [Display(Name = "ID")]
        public int id_marcas { get; set; }

        [Display(Name = "Nombre de la marca")]
        public string? nombre_marca { get; set; }

        [Display(Name = "Estado")]
        public string? estados { get; set; }
    }

    public class tipo_equipo
    {
        [Key]
        public int id_tipo_equipo { get; set; }
        public string descripcion { get; set; }
        public string estados { get; set; }

    }

    public class estados_equipo
    {
        [Key]
        public int id_estados_equipo { get; set; }
        public string descripcion { get; set; }
        public string estados { get; set; }

    }

    //Modelado de las tablas del formulario de la guía 0.8
    public class cursos
    {
        [Key]
        public int id_curso { get; set; }
        public string nombre { get; set; }

    }

    public class usuarios
    {
        [Key]
        public int id_usuario { get; set; }
        public string? nombre { get; set; }
        public string? contrasenya { get; set; }
        public string? genero { get; set; }
        public string? direccion { get; set; }
        public string? pasatiempos { get; set; }
        public int id_curso { get; set; }
        public string? conocimientos { get; set; }


    }


}
