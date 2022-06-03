using Business.Abstracts;
using DataAccess.Abstracts;
using Enities.Concretes.DataTransferObjects;
using Enities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;
        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }
        public bool Add(Role role)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Role role)
        {
            throw new NotImplementedException();
        }

        public Role Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<RoleDetailDTO> GetRolesWithUser(int id)
        {
            return _roleDal.GetRolesWithUser(id);
        }

        public bool Update(Role role)
        {
            throw new NotImplementedException();
        }
    }
}
