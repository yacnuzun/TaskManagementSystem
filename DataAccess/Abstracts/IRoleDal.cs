using Enities.Concretes.DataTransferObjects;
using Enities.Concretes.Models;
using System.Collections.Generic;

namespace DataAccess.Abstracts
{
    public interface IRoleDal : IEntityRepository<Role>
    {
        List<RoleDetailDTO> GetRolesWithUser(int id);
    }
}
