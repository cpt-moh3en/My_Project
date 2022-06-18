using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using My_Project.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;

namespace My_Project.Controllers
{
    public class HomeController : Controller
    {
        readonly My_ProjectContext db;
        public HomeController( My_ProjectContext _db)
        {
            db = _db;
        }

        public IActionResult Index(int id)
        {

            if (id == 1)
            {
                ViewBag.ok = " پیام شما با موفقیت ارسال شد . ";
            }
            else if (id == 2)
            {
                ViewBag.er = " خطا در ارسال پیام . ";
            }
            
            return View();
        }

        public IActionResult Message(Message_ViewModel msg_vm)
        {
            int res ;

            if (msg_vm != null)
            {
                try
                {
                    Message_Tbl msg_tbl = new Message_Tbl()
                    {
                        NameFamily = msg_vm.NameFamily,
                        Email = msg_vm.Email,
                        Subject = msg_vm.Subject,
                        UserMessage = msg_vm.UserMessage,
                        Time = DateTime.Now
                    };

                    db.Tbl_Message.Add(msg_tbl);
                    db.SaveChanges();

                    res = 1;
                }
                catch (System.Exception)
                {
                    res = 2;
                }
            }
            else
            {
                res = 2;
            }

            return RedirectToAction("Index" , new{ id = res });
        }

        [Route("Register")]
        public IActionResult Register(int id)
        {
            if (id == 1)
            {
                ViewBag.ok = " ثبت نام شما با موفقیت انجام شد . ";
            }
            else if (id == 2)
            {
                ViewBag.er = " خطا در ثبت تام . ";
            }
            
            return View();
        }

        public IActionResult SignUp(User_ViewModel user_vm)
        {
            int res ;

            if ( user_vm != null)
            {
                try
                {
                    User_Tbl user_tbl = new User_Tbl()
                    {
                        Name =  user_vm.Name,
                        Family =  user_vm.Family,
                        Email =  user_vm.Email,
                        Age =  user_vm.Age,
                        NationalCode =  user_vm.NationalCode,
                        Education =  user_vm.Education,
                        PhoneNumber =  user_vm.PhoneNumber,
                        Time = DateTime.Now
                    };

                    db.Tbl_User.Add(user_tbl);
                    db.SaveChanges();

                    res = 1;
                }
                catch (System.Exception)
                {
                    res = 2;
                }
            }
            else
            {
                res = 2;
            }

            return RedirectToAction("Register" , new{ id = res });
        }
    }
}
