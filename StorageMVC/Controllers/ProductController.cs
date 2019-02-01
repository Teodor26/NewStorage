using Storage.Models.DataModels;
using Storage.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace StorageMVC.Controllers
{
    public class ProductController : Controller
    {
        private IProductApiService _productService = new ProductApiService();
        // GET: Product
        //public async System.Threading.Tasks.Task<ActionResult> List()
        //{
        //    var productList = await _productService.Getlist();
        //    return View(productList);
        //}

        public ActionResult List()
        {
            IEnumerable<Product> productList = _productService.Getlist();

            return View(productList);
        }
    }
}