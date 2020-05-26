using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NewUserController : Controller
    {
        // GET: NewOrder
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(List_User model)
        {
            ResponseResult result = NewUser_Repo.Create(model);
            return Json(new
            {
                success = result.success,
                message = result.message,
                entity = result.list
            }, JsonRequestBehavior.AllowGet);
        }
    }
}