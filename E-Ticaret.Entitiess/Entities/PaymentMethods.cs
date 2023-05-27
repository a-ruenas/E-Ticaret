using E_Ticaret.Entities;
using E_Ticaret.Entities.Logs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entitiess.Entities
{
    [Table("PaymentMethods")]
    public class PaymentMethods
    {
        public int Id { get; set; }
        public Users User { get; set; }
        public string CartOwnerName { get; set; }
        public string CartOwnerSurname { get; set; }
        public string CardNo { get; set; }
        public string CardCVV { get; set; }
        public int CartDeadlineMonth { get; set; }
        public int CartDeadlineYear { get; set; }
    }
}
