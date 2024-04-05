using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using POO___Razor.Models;

//Controlador para el index de equipos
namespace POO___Razor.Controllers
{
    public class EquiposController : Controller
    {
        private readonly equiposDbContext _equiposDbContext;
        
        public EquiposController(equiposDbContext equiposDbContext) 
        { 
            _equiposDbContext = equiposDbContext;   
        }

        public IActionResult Index()
        {
            //Aquí estamos invocando el listado de marcas de la tabla marcas
            var listaDeMarcas = (from m in _equiposDbContext.marcas
                                 select m).ToList();
            ViewData["listadoDeMarcas"] = new SelectList(listaDeMarcas, "id_marcas", "nombre_marca");

            //Aquí estamos solicitando el listado de los equipos en la bd
            var listadoDeEquipos = (from e in _equiposDbContext.equipos
                                    join m in _equiposDbContext.marcas on e.id_marca equals m.id_marcas
                                    select new
                                    {
                                        nombre = e.nombre,
                                        descripcion = e.descripcion,
                                        id_marca = e.id_marca,
                                        marca_nombre = m.nombre_marca
                                    }).ToList();
            ViewData["listadoEquipo"] = listadoDeEquipos;

            //Aquí listaremos el listado de tipos de equipos
            var listaDeTipoEquipos = (from m in _equiposDbContext.tipo_equipo
                                      select m).ToList();
            ViewData["listadoDeTipoEquipos"] = new SelectList(listaDeTipoEquipos, "id_tipo_equipo", "descripcion");

            //Listado de los tipos de estados de equipo
            var listaDeEstados = (from m in _equiposDbContext.estados_equipo
                                  select m).ToList();
            ViewData["listadoDeEstados"] = new SelectList(listaDeEstados, "id_estados_equipo", "descripcion");


            return View();
        }

        //Función para guardar nuevos equipos
        public IActionResult CrearEquipos(equipos nuevoEquipo)
        {
            _equiposDbContext.Add(nuevoEquipo);
            _equiposDbContext.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
