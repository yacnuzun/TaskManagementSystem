using DataAccess.Abstracts;
using Enities.Concretes.Models;

namespace DataAccess.Concretes
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, TaskManagementContext>, ICategoryDal
    {

    }
}
