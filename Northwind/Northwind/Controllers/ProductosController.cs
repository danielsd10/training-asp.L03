using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class ProductosController : Controller
    {
        NorthwndDbContext BD = new NorthwndDbContext();

        // GET: Categorias
        public ActionResult Index()
        {
            var Productos = BD.CargarProductos();
            ViewBag.Titulo = "Productos";
            return View(Productos);
        }

        // GET: Productos/Nuevo
        [HttpGet]
        public ActionResult Nuevo()
        {
            ViewBag.Categorias = BD.CargarCategorias();
            return View();
        }

        // POST: Productos/Nuevo
        [HttpPost]
        public ActionResult Nuevo(Producto data)
        {
            if (BD.GuardarProducto(data))
            {
            }
            return RedirectToAction("Index");
        }
    }
}