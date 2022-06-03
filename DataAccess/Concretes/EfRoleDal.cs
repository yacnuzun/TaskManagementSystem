using DataAccess.Abstracts;
using Enities.Concretes.DataTransferObjects;
using Enities.Concretes.Models;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concretes
{
    public class EfRoleDal : EfEntityRepositoryBase<Role, TaskManagementContext>, IRoleDal
    {
        public List<RoleDetailDTO> GetRolesWithUser(int id)
        {
            using (TaskManagementContext context = new TaskManagementContext())
            {
                var result = from ur in context.UsersRoles
                             join ro in context.Roles on ur.RoleID equals ro.RoleID
                             join us in context.Users on ur.UserID equals us.UserID
                             where ur.UserID == id

                             select new RoleDetailDTO
                             {
                                 RoleID = ur.RoleID,
                                 RoleName = ro.RoleName,
                                 UserID = ur.UserID,
                                 UserName = us.UserName,
                                 FirstName = us.FirstName,
                                 LastName = us.LastName
                             };
                return result.ToList();
            }
        }
    }
}
