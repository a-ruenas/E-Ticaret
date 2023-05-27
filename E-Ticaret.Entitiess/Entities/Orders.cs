using E_Ticaret.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entitiess.Entities
{
    [Table("Orders")]
    public class Orders
    {
        public int Id { get; set; }
        public virtual Users User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OrderNote { get; set; }
        public virtual List<OrderItems> OrderItems { get; set; }
        public Orders()
        {
            OrderItems = new List<OrderItems>();
        }
    }
    [Table("OrderItems")]
    public class OrderItems
    {
        public int Id { get; set; }
        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
