using BL.BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ImageValidateLogic
    {
        public bool CheckImage(string ImagePath)
        {
            List<string> healthWords = new List<string> { "medicine", "pills", "pill", "pharmacy", "medical", "medication", "drugs", "drug", "healthy", "pill bottle", "prescription drug", "health" };

            bool result = false;
            List<string> descriptions = new List<string>();



            //Will accept only descriptions above t
            double t = 50.0;
            ImageContent img = new ImageContent(ImagePath);
            img.ImageDetails = new Dictionary<string, double>();
            CheckImage dal = new CheckImage();
            dal.GetDescriptions(img);
            foreach (var item in img.ImageDetails)
            {
                if (item.Value > t)
                {
                    descriptions.Add(item.Key);
                }
                else
                {
                    break;
                }


            }
            foreach (var item in descriptions)
            {
                //check if the description suits
                foreach (var name in healthWords)
                {
                    if (name == item)
                        return true;

                }
            }

            return result;
        }
    }
}

//using BL;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace FinalProject.Controllers
//{
//    public class HomeController : Controller
//    {
//        // GET: Home
//        public ActionResult Index()
//        {
//            /*
//            var img ="pill2.jpg";
//            var path = Server.MapPath(Url.Content($"~/images/{img}"));
//            BL.ImageValidateLogic bl = new ImageValidateLogic();
//            bl.CheckImage(path);
//            */
//            List<string> drugCodeNDC = new List<string> { "0781-1506-10" };
//            BL.drugInteractionLogic bl = new BL.drugInteractionLogic();
//            bl.checkInteraction(drugCodeNDC);

//            return View();
//        }
//        // GET: Home/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: Home/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Home/Create
//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Home/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: Home/Edit/5
//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Home/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: Home/Delete/5
//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}