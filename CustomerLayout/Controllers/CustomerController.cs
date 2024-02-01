using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerLayout.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.msg = "welcome to Customer Page";
            return View();
        }

        public ActionResult CustList()
        {
            List<string> ll = new List<string>()
        {
            "Ramesh","Suresh","Naresh"
        };
            ViewBag.CustList = ll;
            return View();
        }
    }
}