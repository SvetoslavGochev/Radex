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
        public IActionResult GetName(string name, [FromHeader]string cookie)
        {
            var view = new TestModel();
            view.Name = name;
            view.Cookie = cookie;

            return this.View(view);
        }

        [NonAction]//ne moje da bade dostapen ot vyn http/Test/GetId no az si go polzvam
        public void GetId()
        {

        }

    }
}
