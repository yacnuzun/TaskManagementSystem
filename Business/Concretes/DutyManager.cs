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
    public class DutyManager : IDutyService
    {
        IDutyDal _dutyDal;
        public DutyManager(IDutyDal dutyDal)
        {
            _dutyDal = dutyDal;
        }

        public bool Add(Duty duty)
        {
            return _dutyDal.Add(duty);
        }

        public bool Delete(Duty duty)
        {
            return _dutyDal.Delete(duty);
        }

        public Duty Get(int id)
        {
            return _dutyDal.Get(d => d.TaskID == id);
        }

        public List<Duty> GetAll()
        {
            return _dutyDal.GetAll();
        }

        public List<DutyDetailDTO> GetDutiesWithRelation()
        {
            return _dutyDal.GetDutiesWithRelation();
        }

        public bool Update(Duty duty)
        {
            return _dutyDal.Update(duty);

        }
    }
}
