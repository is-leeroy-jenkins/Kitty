using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Project.Models;

namespace Project.Controllers
{
    public class ClassNameController : Controller
    {
        [HttpGet("/className")]
        public ActionResult Index()
        {
            return View();
        }
    }
}