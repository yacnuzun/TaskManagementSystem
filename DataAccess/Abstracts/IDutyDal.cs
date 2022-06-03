using System;
using System.Collections.Generic;
using Enities.Concretes.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Enities.Concretes.DataTransferObjects;

namespace DataAccess.Abstracts
{
    public interface IDutyDal : IEntityRepository<Duty>
    {
        List<DutyDetailDTO> GetDutiesWithRelation(Expression<Func<Duty, bool>> filter = null);
    }
}
