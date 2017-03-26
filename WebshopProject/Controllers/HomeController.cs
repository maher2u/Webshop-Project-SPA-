using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebshopProject.Models;

namespace WebshopProject.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: Home/Index
        public ActionResult Index()
        {
            //My idea is we will use this standard MVC model on index.cshtml, and AngularJS data in product views
            ModelClass shopModel = new ModelClass();

            return View(shopModel);
        }
    }
}