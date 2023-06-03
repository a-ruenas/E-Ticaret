using E_Ticaret.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entitiess.Logs
{
    public class BaseLog<T>
    {
        [Key]
        public int LogId { get; set; }
        public virtual T Modified { get; set; }
        public virtual Users ModifierUser { get; set; }
        public DateTime ModifiedOn { get; set; }
        public enum Action
        {
            Created,
            Updated,
            Deleted
        }
    }
}
