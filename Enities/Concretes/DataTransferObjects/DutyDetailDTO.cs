using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enities.Concretes.DataTransferObjects
{
    public class DutyDetailDTO
    {
        public int TaskID { get; set; }
        public string CategoryName { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public string DirectedName { get; set; }
        public string Statu { get; set; }
    }
}
