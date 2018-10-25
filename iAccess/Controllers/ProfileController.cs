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
            if (Session["Me"] != null)
            {
                getEmployeeData_Result Model = Session["Me"] as getEmployeeData_Result;
                ViewData.Model = Model;
                return View(Model);
            }
            else
            {
                return RedirectToAction("Home", "Index");
            }            
        }

        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            return View();
        }
    }
}