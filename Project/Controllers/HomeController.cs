using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Project.Models;

namespace  Project.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}