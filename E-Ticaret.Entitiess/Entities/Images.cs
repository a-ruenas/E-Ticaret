using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entities
{
    [Table("Images")]
    public class Images
    {
        public int Id { get; set; }
        public Products Product { get; set; }
        public string ImageAdress { get; set; }
    }
}
