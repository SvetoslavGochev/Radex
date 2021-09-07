
namespace Radex.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Radex.Data;
    using System;

    [Route("[controller]")]//opennig on name of controller
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        public Product Test()
        {

            return new Product
            {
                ActiveForm = DateTime.UtcNow,
                Descriptions = "descroption",
                Id = 123,
                Name = "name",
                Price = 123.34
            };
        }

    }
}
