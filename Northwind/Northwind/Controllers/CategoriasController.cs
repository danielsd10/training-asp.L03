using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.Controllers
{
    public class CategoriasController : Controller
    {
        NorthwndDB DB = new NorthwndDB();

        // GET: Categorias
        public ActionResult Index()
        {
            return View(DB.Categories);
        }

        // GET: Categorias/Nuevo
        public ActionResult Nuevo()
        {
            return View();
        }
    }
}