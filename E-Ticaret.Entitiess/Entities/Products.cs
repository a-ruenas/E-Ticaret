using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace E_Ticaret.Entities
{
    [Table("Products")]
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<Images> Images { get; set; }
        public Products()
        {
            Images = new List<Images>();
        }
    }
}
