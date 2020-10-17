using EdTech_game.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace EdTech_game.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          
            return View();
        }
        public ActionResult Photo(string vendorId)
        {
            ViewBag.Message = "Your application description page.";
            PhotoData model = new PhotoData();
            model.vendorId = vendorId;
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(PhotoData model)
        {
            ViewBag.Message = "Your application description page.";
            if (model != null) {
                MultipartFileData f= model.image;
              string vendorId=  model.vendorId;
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}