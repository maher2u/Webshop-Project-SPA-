using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebshopProject.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Start()
        {
            return View();
        }

        // GET: Products/Product1
        public ActionResult Product1()
        {
            return View();
        }

        // GET: Products/Product2
        public ActionResult Product2()
        {
            return View();
        }

        // GET: Products/Toplist
        public ActionResult Top2017()
        {
            return View();
        }
    }
}