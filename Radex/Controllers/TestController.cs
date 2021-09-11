namespace Radex.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Radex.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class TestController : Controller
    {
        [HttpGet]
        [HttpPost]
        [RequireHttps]
        //controler/action/id?
        public IActionResult GetName(int year, int mont, int day,int id,string name, [FromHeader]string cookie)
        {

            this.ViewBag.test = 1;
            this.ViewData["test"] = 123;
            var view = new TestModel();
            view.Name = name;
            view.Cookie = cookie;
            view.Id = id.ToString();//trtiq parametyr //controler/action/id?
            view.Date = $"{year}/{mont}///////////';////////////////////////////////////////////////////{day}";

            return this.View(view);
        }

        [NonAction]//ne moje da bade dostapen ot vyn http/Test/GetId no az si go polzvam
        public void GetId()
        {

        }

    }
}
