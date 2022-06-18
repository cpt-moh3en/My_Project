using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models ;
using System.Globalization;
using My_Project.Context;
using ExtensionMethod;

namespace My_Project.Controllers
{
    public class ResultController : Controller
    {
        readonly My_ProjectContext db;
        public ResultController( My_ProjectContext _db)
        {
            db = _db;
        }

        public IActionResult Index(int id)
        {
            if (id == 0)
            {
                ViewBag.er = " خطا در ورود ...! ";
            }

            return View();
        }

        public IActionResult Set_Password(Login_ViewModel login_vm)
        {
            if (login_vm.UserName == "1" && login_vm.Password == "1")
            {
                return RedirectToAction("Menu");
            }
            else
            {
                return RedirectToAction("Index" , new{ id = 0 });
            }
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Message()
        {
            var msg = db.Tbl_Message.OrderByDescending(n => n.Id).ToList();
            List<Message_ViewModel> l_msg = new List<Message_ViewModel>();

            foreach (var item in msg)
            {
                Message_ViewModel msg_vm = new Message_ViewModel
                {
                    NameFamily = item.NameFamily,
                    Email = item.Email,
                    Subject = item.Subject,
                    UserMessage = item.UserMessage,
                    Time = item.Time.ToPersianDateTime() ,
                };

                l_msg.Add(msg_vm);
            }

            return View(l_msg);
        }

        public IActionResult SignUp()
        {
            var user = db.Tbl_User.OrderByDescending(n => n.Id).ToList();
            List<User_ViewModel> l_user = new List<User_ViewModel>();

            foreach (var item in user)
            {
                User_ViewModel user_vm = new User_ViewModel
                {
                    Name = item.Name,
                    Family = item.Family,
                    Email = item.Email,
                    Age = item.Age,
                    NationalCode = item.NationalCode,
                    Education = item.Education,
                    PhoneNumber = item.PhoneNumber,
                    Time = item.Time.ToPersianDateTime(),
                };

                l_user.Add(user_vm);
            }

            return View(l_user);
        }

    }
}