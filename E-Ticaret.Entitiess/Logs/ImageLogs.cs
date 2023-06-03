using E_Ticaret.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entitiess.Logs
{
    public class ImageLogs: BaseLog<Images>
    {
        public virtual Products OldProduct { get; set; }
        public string OldImageAdress { get; set; }
    }
}
