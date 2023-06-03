using E_Ticaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entitiess.Logs
{
    public class ProductLogs : BaseLog<Products>
    {
        public string OldName { get; set; }
        public decimal OldPrice { get; set; }
        public string OldDescription { get; set; }
        public virtual List<ImageLogs> OldImages { get; set; }
        public ProductLogs()
        {
            OldImages = new List<ImageLogs>();
        }
    }
}
