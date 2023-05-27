using E_Ticaret.Entitiess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entities
{
    [Table("Users")]
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public virtual Carts Cart { get; set; }
        public virtual List<PaymentMethods> PaymentMethods { get; set; }
        public Users()
        {
            PaymentMethods = new List<PaymentMethods>();
        }
    }
}
