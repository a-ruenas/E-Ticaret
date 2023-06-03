using E_Ticaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entitiess.Logs
{
    public class CategoryLogs : BaseLog<Categories>
    {
        public string OldName { get; set; }
        public string OldDescription { get; set; }
        public virtual List<Products> OldProducts { get; set; }
        public CategoryLogs()
        {
            OldProducts = new List<Products>();
        }
    }
}
