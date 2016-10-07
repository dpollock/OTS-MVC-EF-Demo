using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OTS_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var message = new Company { CompanyName = "OTS", NumofEmployees = 63,
                Address= new Address { StreetAddress = "123 Main St", City = "Kochi" }
            };

            return Json(message, JsonRequestBehavior.AllowGet);
        }


        public ActionResult IndexFile()
        {
           

            return File(Server.MapPath("~/project_readme.html"), "plain/text");
        }


    }

    public class Address
    {
        public string City { get; set; }
        public string StreetAddress { get; set; }
    }

    public class Company
    {
        public string CompanyName { get; set; }
        public int NumofEmployees { get; set; }
        public Address Address { get; set; }
    }
}