using Enities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enities.Concretes.Models
{
    public class Statu : IEntity
    {
        public int StatuID { get; set; }
        public string StatuName { get; set; }

        public virtual List<Duty> Duties { get; set; }
    }
}
