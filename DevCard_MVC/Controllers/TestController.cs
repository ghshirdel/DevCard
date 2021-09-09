using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //public ContentResult Index()
        //{
        //    return Content($"<h1> Hooman Shirdel </h1>");
        //}
        //دانلود فایل توسط کاربر
        //public FileResult Index()
        //{
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/Text.txt");
        //    const string fileName = "TextFile.txt";
        //    return File(fileByte, MediaTypeNames.Text.Plain, fileName);
        //}
        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        Id=1,
        //        Name="Hooman Shirdel",
        //        Job="Programmer",
        //        Site="SAMSmart.com",
        //        Address="Darband Ahmadi Zamni Neshat no 8"
        //    });
        //}
        //public RedirectToActionResult index()
        //{
        //    return RedirectToAction("Contact", "Home");
        //}
        public IActionResult Index()
        {
            return new StatusCodeResult(404);
        }

    }
}
