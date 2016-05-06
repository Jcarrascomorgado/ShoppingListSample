using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ticket : EntityBase
    {
        public virtual ICollection<Details> Detail{ get; set; }
        public DateTime Date { get; set; }

    }
}
