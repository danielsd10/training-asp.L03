using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Northwind.Models
{
    public class NorthwndDbContext : DbContext
    {
        public NorthwndDbContext()
            : base("NorthwndDB")
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public IQueryable<Categoria> CargarCategorias()
        {
            return from c in this.Categorias
            orderby c.Nombre ascending
            select c;
        }

        public bool GuardarCategoria(Categoria objCategoria)
        {
            int items;
            Categorias.Add(objCategoria);
            items = this.SaveChanges();
            return items > 0;
        }

        public IQueryable<Producto> CargarProductos()
        {
            return from p in this.Productos
                   orderby p.Nombre ascending
                   select p;
        }

        public bool GuardarProducto(Producto objProducto)
        {
            int items;
            Productos.Add(objProducto);
            items = this.SaveChanges();
            return items > 0;
        }
    }
}