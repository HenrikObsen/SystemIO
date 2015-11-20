using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemIO.Helpers;

namespace SystemIO.Controllers
{
    public class DirController : Controller
    {
        
        FileTools ft = new FileTools();
        DirTools dt = new DirTools();

        public ActionResult VisMapperFile()
        {
            string path = Request.PhysicalApplicationPath;

            ViewBag.Mapper = dt.GetAllFolders(path);
            ViewBag.Filer = ft.GetAllFiles(path);

            return View();
        }
    }
}