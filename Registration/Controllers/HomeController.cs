using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Registration.Models;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        DataLayer dl = new DataLayer();
        public ActionResult Index()
        {
            Property p = new Property();
            p.action = 2;
            p.dt = dl.ExecuteData(p);
            return View(p);
        }
        public ActionResult Register(Property p)
        {
            DataTable dt = new DataTable();
                dt=dl.ExecuteData(p);
            return Json("Registration Successfull ");
        }
    }
}