using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Models
{
    [Table("Categories")]
    public class Categoria
    {
        [Column("CategoryID")]
        public int Id { get; set; }

        [Column("CategoryName")]
        public string Nombre { get; set; }

        [Column("Description")]
        public string Descripcion { get; set; }
    }
}