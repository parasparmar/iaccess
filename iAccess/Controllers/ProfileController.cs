using iAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iAccess.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            DB my = new DB();
            string myNTID = PageExtensionMethods.getMyWindowsID().ToString();
            myNTID = "gsing017";
            getEmployeeData_Result Model = my.getEmployeeData(myNTID).FirstOrDefault();
            ViewData.Model = Model;
            return View(Model);
        }

        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            return View();
        }
    }
}