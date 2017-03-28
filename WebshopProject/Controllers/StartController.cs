using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebshopProject.Models;

namespace WebshopProject.Controllers
{
    
    public class StartController : Controller
    {
        // GET: Start/index
        public ActionResult index()
        {
            //My idea is we will use this standard MVC model on index.cshtml, and AngularJS data in product views
            ModelClass shopModel = new ModelClass();

            return View(shopModel);
        }
    }
}