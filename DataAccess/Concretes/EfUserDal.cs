using DataAccess.Abstracts;
using Enities.Concretes.Models;

namespace DataAccess.Concretes
{
    public class EfUserDal : EfEntityRepositoryBase<User, TaskManagementContext>, IUserDal
    {

    }
}
