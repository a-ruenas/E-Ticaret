using E_Ticaret.Entities;
using E_Ticaret.Entitiess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entitiess.Logs
{
    public class OrderLogs : BaseLog<Orders>
    {
        public virtual Users OldUser { get; set; }
        public string OldFirstName { get; set; }
        public string OldLastName { get; set; }
        public string OldAddress { get; set; }
        public string OldCity { get; set; }
        public string OldPhone { get; set; }
        public string OldEmail { get; set; }
        public string OldOrderNote { get; set; }
        public virtual List<OldOrderItems> OldOrderItems { get; set; }
        public OrderLogs()
        {
            OldOrderItems = new List<OldOrderItems>();
        }
    }
    public class OldOrderItems
    {
        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
