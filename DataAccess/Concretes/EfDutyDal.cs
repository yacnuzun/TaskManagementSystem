using DataAccess.Abstracts;
using Enities.Concretes.DataTransferObjects;
using Enities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfDutyDal : EfEntityRepositoryBase<Duty, TaskManagementContext>, IDutyDal
    {
        public List<DutyDetailDTO> GetDutiesWithRelation(Expression<Func<Duty, bool>> filter = null)
        {
            using (TaskManagementContext context = new TaskManagementContext())
            {
                var result = from d in context.Duties
                             join c in context.Categories on d.CategoryId equals c.CategoryID
                             join u in context.Users on d.UserId equals u.UserID
                             join m in context.Users on d.DirectedId equals m.UserID
                             join s in context.Status on d.StatuId equals s.StatuID

                             select new DutyDetailDTO
                             {
                                 TaskID = d.TaskID,
                                 CategoryName = c.CategoryName,
                                 TaskName = d.TaskName,
                                 Description = d.Description,
                                 UserName = u.FirstName + " " + u.LastName,
                                 DirectedName = m.FirstName + " " + m.LastName,
                                 Statu = s.StatuName
                             };
                return result.ToList();
            }
        }
    }
}
