using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Models
{
    [Table("Products")]
    public class Producto
    {
        [Column("ProductID")]
        public int Id { get; set; }

        [Column("ProductName")]
        public string Nombre { get; set; }

        [Column("CategoryID")]
        public Nullable<int> IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set; }
    }
}