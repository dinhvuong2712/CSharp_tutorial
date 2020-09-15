using Model.DAO;
using Model.Entity_Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Story.Areas.AdminStory.Controllers
{
    public class ComicControlController : Controller
    {
        // GET: AdminStory/ComicControl
        public ActionResult Index(int? currentPage, int? pageSize)
        {
            int totalPage;
            ViewBag.ListPage = new ComicDAO().PageList(currentPage, pageSize, out totalPage);
            ViewBag.CurrentPage = currentPage;
            ViewBag.TotalPage = totalPage;
            return View();
        }

        // GET: AdminStory/ComicControl/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminStory/ComicControl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminStory/ComicControl/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminStory/ComicControl/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View();
        }

        // POST: AdminStory/ComicControl/Edit/5
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

        // GET: AdminStory/ComicControl/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminStory/ComicControl/Delete/5
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

        /*public string EditImage(string path, HttpPostedFileBase fileBase, Comic comic)
        {
            string fileName = Path.GetFileNameWithoutExtension(fileBase.FileName)*//*get name file*//*;
            fileName += "_" + comic.comicId;
            fileName += Path.GetExtension(fileBase.FileName);//get đuôi file
            string folderPath = Server.MapPath("~") + path;
        }*/
    }
}
