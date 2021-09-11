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
        public IActionResult GetName(string name)
        {
            var view = new TestModel();
            view.Name = name;

            return this.View(view);
        }


    }
}
