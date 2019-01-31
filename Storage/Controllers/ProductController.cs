using Storage.Filters;
using StorageBusiness.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Storage.Controllers
{
    public class ProductController : ApiController
    {
        private IProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        //[ZeroDivideHandlerFilter]
        //public IHttpActionResult Get()
        //{
        //    List<string> result = new List<string>();

        //    //for (int i = 0; i < 100; i++)
        //    //{
        //    //    result.Add((i / i - 1).ToString());
        //    //}
        //    return Ok(result);

        //}

        public IHttpActionResult GetAll()
        {
            var products = _productService.GetAll();

            return Ok(products);
        }

        [HttpGet]
        public IHttpActionResult GetOne(int Id)
        {
            var product = _productService.GetAll().ToString();

            return Ok(product);

        }
    }
}
