using Enities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enities.Concretes.Models
{
    public class Category :IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public virtual List<Duty> Duties { get; set; }
    }
}
