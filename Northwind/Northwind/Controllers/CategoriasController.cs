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
        NorthwndDbContext BD = new NorthwndDbContext();

        // GET: Categorias
        public ActionResult Index()
        {
            var Categorias = BD.CargarCategorias();
            ViewBag.Titulo = "Categorías";
            return View(Categorias);
        }

        // GET: Categorias/Nuevo
        [HttpGet]
        public ActionResult Nuevo()
        {
            return View();
        }

        // POST: Categorias/Nuevo
        [HttpPost]
        public ActionResult Nuevo(Categoria data)
        {
            if (BD.GuardarCategoria(data))
            {
            }
            return RedirectToAction("Index");
        }
    }
}