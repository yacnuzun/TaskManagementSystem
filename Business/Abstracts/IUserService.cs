using Enities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface IUserService
    {
        List<User> GetAll();
        User Get(int id);
        bool Add(User user);
        bool Delete(User user);
        bool Update(User user);
    }
}
