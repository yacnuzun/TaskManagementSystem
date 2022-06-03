using Enities.Concretes.DataTransferObjects;
using Enities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface IDutyService
    {
        List<Duty> GetAll();
        Duty Get(int id);
        List<DutyDetailDTO> GetDutiesWithRelation();
        bool Add(Duty duty);
        bool Delete(Duty duty);
        bool Update(Duty duty);
    }
}
