using Enities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface IStatuService
    {
        List<Statu> GetAll();
        Statu Get(int id);
        bool Add(Statu statu);
        bool Delete(Statu statu);
        bool Update(Statu statu);
    }
}
