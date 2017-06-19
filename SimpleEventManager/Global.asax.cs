using SimpleEventManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SimpleEventManager
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new ApplicationDbContextSeeder());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            CultureInfo culture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            culture.DateTimeFormat.DateSeparator = "/";
            culture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            culture.DateTimeFormat.FullDateTimePattern = "dd/MM/yyyy HH:mm";
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
        }
    }
}
