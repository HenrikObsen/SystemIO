using System.Web.Mvc;
using SystemIO.Helpers;

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
    }
}


