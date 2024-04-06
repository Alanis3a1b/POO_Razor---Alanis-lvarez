using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using POO___Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;

//Controlador para la vista de vistasRazorController1
namespace POO___Razor.Controllers
{
    public class vistasRazorController1 : Controller
    {
        private readonly equiposDbContext _equiposDbContext;

        public vistasRazorController1(equiposDbContext equiposDbContext)
        {
            _equiposDbContext = equiposDbContext;
        }


        // GET: vistasRazor

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult bloqueMultiple()
        {
            return View();
        }

        public ActionResult condiciones() 
        {
            return View();
        }

        public ActionResult bucles()
        {
            return View();
        }

        public ActionResult formulario()
        {
            //Aquí estamos invocando el listado de los cursos
            var listaDeCursos = (from m in _equiposDbContext.cursos
                                 select m).ToList();
            ViewData["listadoDeCursos"] = new SelectList(listaDeCursos, "id_curso", "nombre");


            //Aquí estamos solicitando el listado de los usuarios
            var listadoDeUsuarios = (from e in _equiposDbContext.usuarios
                                    join m in _equiposDbContext.cursos on e.id_curso equals m.id_curso
                                    select new
                                    {
                                        nombre = e.nombre,
                                        direccion = e.direccion,
                                        curso = e.id_curso
                                    }).ToList();
            ViewData["listadoUsuarios"] = listadoDeUsuarios;

            return View();
        }

        //Función para guardar nuevos usuario
        //(usuarios nuevoUsuario) ---> ("nombre tabla a meter datos" "variable")
        public IActionResult CrearUsuarios(usuarios nuevoUsuario)
        {
            _equiposDbContext.Add(nuevoUsuario);
            _equiposDbContext.SaveChanges();

            return RedirectToAction("Formulario");

        }
    }
}
