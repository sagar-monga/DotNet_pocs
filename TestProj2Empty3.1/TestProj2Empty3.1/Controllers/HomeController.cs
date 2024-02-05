using System;
using Microsoft.AspNetCore.Mvc;

namespace TestProj2Empty3._1.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            // return "Hello from MVC";
            return Json(new { id = 1, name = "test" });
        }
    }
}
