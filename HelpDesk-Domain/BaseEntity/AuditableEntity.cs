using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_Domain.BaseEntity
{
    public abstract class AuditableEntity
    {
        public virtual int Id { get; set; }
    }
}
