using E_Ticaret.Entities;
using E_Ticaret.Entitiess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entitiess.Logs
{
    public class PaymentMethodLogs:BaseLog<PaymentMethods>
    {
        public virtual Users OldUser { get; set; }
        public string OldCartOwnerName { get; set; }
        public string OldCartOwnerSurname { get; set; }
        public string OldCardNo { get; set; }
        public string OldCardCVV { get; set; }
        public int OldCartDeadlineMonth { get; set; }
        public int OldCartDeadlineYear { get; set; }
    }
}
