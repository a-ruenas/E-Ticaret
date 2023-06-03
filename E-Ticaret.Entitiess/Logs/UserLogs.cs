using E_Ticaret.Entitiess.Logs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entities.Logs
{
    [Table("UserLogs")]
    public class UserLogs:BaseLog<Users>
    {
        public string OldUsername { get; set; }
        public string OldFirstName { get; set; }
        public string OldLastName { get; set; }
        public string OldPassword { get; set; }
        public string OldEmail { get; set; }
        public bool OldIsAdmin { get; set; }
    }
}
