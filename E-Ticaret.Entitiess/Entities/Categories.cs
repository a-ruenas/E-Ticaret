using E_Ticaret.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entitiess
{
    [Table("Categories")]
    public class Categories
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Products> Products { get; set; }
        public Categories()
        {
            Products = new List<Products>();
        }
    }
}
