using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*
Menu changes
https://joeylicc.wordpress.com/2014/10/03/asp-net-mvc-5-menu-using-site-map-provider-bootstrap-3-navbar/
*/
namespace YourGrowth.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }
        // GET: Admin/Admin
        public ActionResult Programs()
        {
            return View();
        }

        // GET: Admin/Admin
        public ActionResult Routines()
        {
            return View();
        }
        // GET: Admin/Admin
        public ActionResult Exercies()
        {
            return View();
        }

        // GET: Admin/Admin
        public ActionResult Groups()
        {
            return View();
        }
        
        // GET: Admin/Admin
        public ActionResult Muscles()
        {
            return View();
        }
    }
}