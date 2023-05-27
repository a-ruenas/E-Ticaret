using E_Ticaret.Entitiess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entities
{
    [Table("Carts")]
    public class Carts
    {
        public int Id { get; set; }
        public virtual Users User { get; set; }
        public decimal Total { get; set; }
        public virtual List<CartItems> CartItems { get; set; }
        public Carts()
        {
            CartItems = new List<CartItems>();
        }
    }
    [Table("CartItems")]
    public class CartItems
    {
        public int Id { get; set; }
        public virtual Products Product { get; set; }
        public virtual Carts Cart { get; set; }
        public int Quantity { get; set; }
    }
}
