﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enities.Concretes.DataTransferObjects
{
    public class RoleDetailDTO
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
