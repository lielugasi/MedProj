using BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

       

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public bool Create(FormCollection collection)
        {
            HttpFileCollectionBase files = Request.Files;
            int length = files[0].ContentLength;
            var bytes = new byte[length];
            var file = files[0];
            file.InputStream.Read(bytes,0,length);
            string fileName = Path.GetFileName(file.FileName);
            if (!Directory.Exists(@"D:\apptest\"))
                Directory.CreateDirectory(@"D:\apptest\");
            string path = @"D:\apptest\"+ fileName;
            System.IO.File.WriteAllBytes(path,bytes);
           // var img = "pill2.jpg";
           // var path = Server.MapPath(Url.Content($"~/images/{img}"));
            BL.ImageValidateLogic bl = new ImageValidateLogic();
           // System.IO.File.Delete(path);
         return   bl.CheckImage(path);



            //try
            //{
            //    // TODO: Add insert logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
