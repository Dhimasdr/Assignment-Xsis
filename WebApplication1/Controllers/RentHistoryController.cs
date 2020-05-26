using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class RentHistoryController : Controller
    {
        // GET: RentHistory
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return PartialView("_List", RentList_Repo.All());
        }

        public ActionResult Search(string search = "")
        {

            return PartialView("_List", RentList_Repo.Search(search));
        }
    }
}