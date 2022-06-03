using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Enities.Concretes.DataTransferObjects;
using Enities.Concretes.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            using (TaskManagementContext context = new TaskManagementContext())
            {
                RoleManager roleManager = new RoleManager(new EfRoleDal());
                User loginUser = context.Users.FirstOrDefault(x => x.UserName == model.User.UserName && x.Password == model.User.Password);
                if (loginUser != null)
                {
                    List<RoleDetailDTO> roles = roleManager.GetRolesWithUser(loginUser.UserID);
                    List<Claim> claims = new List<Claim>();
                    foreach (var claim in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Name, claim.UserName));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, claim.RoleName));
                    }
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    await HttpContext.SignInAsync(claimsPrincipal);

                    string jsonValue = JsonConvert.SerializeObject(roles);
                    HttpContext.Session.SetString("user",jsonValue);
                    return RedirectToAction("Index", "Duty");
                }
                ModelState.AddModelError("", "Wrong Password or username!");
                return View();
            }
        }

    }
}
