using Enities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enities.Concretes.Models
{
    public class Role : IEntity
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public virtual List<UserRole> UserRole { get; set; }

    }
}
