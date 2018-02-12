﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class ProductosController : Controller
    {
        NorthwndDbContext DB = new NorthwndDbContext();

        // GET: Categorias
        public ActionResult Index()
        {
            var Productos = DB.CargarProductos();
            ViewBag.Titulo = "Productos";
            return View(Productos);
        }

        // GET: Categorias/Nuevo
        public ActionResult Nuevo()
        {
            return View();
        }
    }
}