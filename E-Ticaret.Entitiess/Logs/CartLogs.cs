using E_Ticaret.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entitiess.Logs
{
    public class CartLogs:BaseLog<Carts>
    {
        public class Carts
        {
            public virtual Users User { get; set; }
            public decimal Total { get; set; }
            public virtual List<OldCartItems> OldCartItems { get; set; }
            public Carts()
            {
                OldCartItems = new List<OldCartItems>();
            }
        }
        public class OldCartItems
        {
            public virtual Products Product { get; set; }
            public virtual Carts Cart { get; set; }
            public int Quantity { get; set; }
        }
    }
}
