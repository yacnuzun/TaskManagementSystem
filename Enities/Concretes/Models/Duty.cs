using Enities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enities.Concretes.Models
{
    public class Duty : IEntity
    {
        [Key]
        public int TaskID { get; set; }
        public int CategoryId { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public int DirectedId { get; set; }
        public int StatuId { get; set; }

        public virtual Statu Statu { get; set; }
        public virtual Category Category  { get; set; }
    }
}
