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
        // GET: Start
        public ActionResult Index()
        {
            ModelClass shopModel = new ModelClass();

            return View(shopModel);
        }
    }
}