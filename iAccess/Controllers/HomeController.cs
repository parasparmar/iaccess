using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iAccess.Models;

namespace iAccess.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public ActionResult Index()
        {            
            DB my = new DB();
            string myNTID = PageExtensionMethods.getMyWindowsID().ToString();
            myNTID = "gsing017";
            getEmployeeData_Result Model = my.getEmployeeData(myNTID).FirstOrDefault();
            ViewData.Model = Model;

            return View(Model);
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
    }
}