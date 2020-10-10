using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyInjection.BLL.Catalog;

namespace DependencyInjection.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAppObject _appObject;

        public HomeController(IAppObject appObject)
        {
            _appObject = appObject;
        }
        public string Index()
        {
            return _appObject.GetName();
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