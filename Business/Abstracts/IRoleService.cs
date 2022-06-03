using Enities.Concretes.DataTransferObjects;
using Enities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface IRoleService
    {
        List<Role> GetAll();
        List<RoleDetailDTO> GetRolesWithUser(int id);
        Role Get(int id);
        bool Add(Role role);
        bool Delete(Role role);
        bool Update(Role role);
    }
}
