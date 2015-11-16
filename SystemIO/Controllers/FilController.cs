using System.Web.Mvc;
using SystemIO.Helpers;

namespace SystemIO.Controllers
{
    public class FilController : Controller
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


    }
}