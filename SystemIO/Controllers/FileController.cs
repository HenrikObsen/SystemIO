﻿using System.Web.Mvc;
using System.IO;
using SystemIO.Helpers;
using System;
using System.Web;

namespace SystemIO.Controllers
{
    public class FileController : Controller
    {
        FileTools ft = new FileTools();

        public ActionResult CreateFile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFile(string fileName)
        {
            string filePath = Request.PhysicalApplicationPath + "/Filer/" + fileName;
            ViewBag.MSG = ft.CreateFile(filePath);

            return View("CreateFile");
        }

        public ActionResult DeleteFile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteFile(string fileName)
        {
            string filePath = Request.PhysicalApplicationPath + "/Filer/" + fileName;
            ViewBag.MSG = ft.DeleteFile(filePath);

            return View();
        }

   
        public ActionResult WriteToFile()
        {
            string filePath = Request.PhysicalApplicationPath + "/Filer/MyStyle.css";
            ViewBag.Style = ft.ReadFromFile(filePath);

            return View();
        }

        [HttpPost]
        public ActionResult WriteToFile(string text)
        {
            string filePath = Request.PhysicalApplicationPath + "/Filer/MyStyle.css";

            ft.WritToFile(filePath, text);

            ViewBag.Style = text;
            
            return View();
        }

        public ActionResult GetFiles()
        {
            string path = Request.PhysicalApplicationPath + "/Filer/";
           
            return View(ft.GetAllFiles(path));
        }

        public ActionResult UploadFil()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFil(HttpPostedFileBase fil)
        {
            string path = Request.PhysicalApplicationPath + "/Filer/";
            string newPath = ft.UploadFile(fil, path);

            ft.ReSizeImage(newPath, path + "300/", 300);

            ViewBag.MSG = "Filen (" + Path.GetFileName(newPath) + ") er uploadet!";

            return View();
        }
    }
}


