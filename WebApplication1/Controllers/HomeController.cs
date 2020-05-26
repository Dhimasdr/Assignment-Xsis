//using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using ViewModel;
using DataAccess;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddOrder()
        {
            return PartialView("_Order", new Rent_lists());
        }
        [HttpPost]
        public ActionResult Create(Rent_lists model)
        {
            ResponseResult result = NewRent_Repo.Create(model);
            return Json(new
            {
                success = result.success,
                message = result.message,
                entity = result.list
            }, JsonRequestBehavior.AllowGet);
        }
    }
}