﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using iAccess.Models;

namespace iAccess
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);           
        }


        public void Application_Error(object sender, EventArgs e)
        {
            //// Code that runs when an unhandled error occurs
            //if (HttpContext.Current.Server.GetLastError() != null)
            //{
            //    // Get the exception object.
            //    Exception exc = Server.GetLastError().GetBaseException();
            //    string urlPath = Request.Url.ToString();
            //    string id = ExceptionUtility.LogException(exc, urlPath);
            //    Server.ClearError();
            //    //Server.Transfer(404/id);

            //}
        }
    }
}
