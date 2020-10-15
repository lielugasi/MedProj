using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class MineController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            BL.ImageTagsLogic j = new BL.ImageTagsLogic();
            j.Uplaod(file);
            return View();
        }
    }
}