using RCS.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RCS.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {
            RSCServiceClient = new RCSService.RCSServiceClient();
        }

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

        public ActionResult Test()
        {
            Test text = RSCServiceClient.Test();
            return View((object)text);
        }
    }
}