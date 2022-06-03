using Enities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category Get(int id);
        bool Add(Category category);
        bool Delete(Category category);
        bool Update(Category category);
    }
}
