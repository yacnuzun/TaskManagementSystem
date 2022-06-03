using Enities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface IUserRoleService
    {
        List<UserRole> GetAll();
        UserRole Get(int id);
        bool Add(UserRole userRole);
        bool Delete(UserRole userRole);
        bool Update(UserRole userRole);
    }
}
