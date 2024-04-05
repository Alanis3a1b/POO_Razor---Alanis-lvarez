using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;

namespace POO___Razor.Controllers
{
    public class vistasRazorController1 : Controller
    {
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
            return View();
        }
    }
}
