using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes;
using Enities.Concretes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class DutyController : Controller
    {
        IDutyService _dutyManger = new DutyManager(new EfDutyDal());
        public IActionResult Index()
        {
            ListDutiesViewModel model = new ListDutiesViewModel();
            model.Duties = _dutyManger.GetDutiesWithRelation();
            return View(model);
        }
    }
}
