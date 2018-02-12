using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class CategoriasController : Controller
    {
        NorthwndDbContext DB = new NorthwndDbContext();

        // GET: Categorias
        public ActionResult Index()
        {
            var Categorias = DB.CargarCategorias();
            ViewBag.Titulo = "Categorías";
            return View(Categorias);
        }

        // GET: Categorias/Nuevo
        public ActionResult Nuevo()
        {
            return View();
        }
    }
}