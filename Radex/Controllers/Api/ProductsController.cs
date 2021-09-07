﻿namespace Radex.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using Radex.Data;
    using System;

    [Route("api/[controller]")]//opennig on name of controller
    // open on adress /api/Products za vsi`ki mewtodi pytq e edin i sy6t
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        public Product Test()
        {
            //if (!this.ModelState.IsValid)
            //{ ako ne6to ne e okei v dannite
            //    return BadRequest(tModelState);
            //} tova ne go pravim to e avtomati4no za api kontrolerite

            return new Product
            {
                ActiveForm = DateTime.UtcNow,
                Descriptions = "descroption",
                Id = 123,
                Name = "name",
                Price = 123.34M,
            };
            //vra]a go kato jSon

        }

        [HttpDelete]
        public string SoftUni()
        {
            return "Delete!";
        }
        // /api/products/12345 tova e adresa
        [HttpPost("{id}")]
        public Product SoftUni2(Product product, int Id)
        {
            //ako ne6to e slojen tip se tarsi v bodito s json ako e primitiven se tarsi v queri stringa  gore https://localhost:8080/Api/Products?id=123
            //pri [HttpPost]
            product.Id = Id;
            return product;
        }

    }
}
