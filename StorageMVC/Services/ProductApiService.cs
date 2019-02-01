using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Storage.Services
{
    public interface IProductApiService
    {
        Task<List<Product>> Getlist();
    }

    public class ProductApiService : IProductApiService
    {
        public async Task<List<Product>> Getlist()
        {
            HttpClient client = new HttpClient();

            string apiEndpoint = StorageMVC.Properties.Settings.Default.ApiEndpoint;

            client.BaseAddress = new Uri("http://localhost:54335");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                List<Product> products = new List<Product>();
            var responce = await client.GetAsync("products");

            if(responce.IsSuccessStatusCode)
            {
                products = await responce.Content.ReadAsAsync<List<Product>>();
            }

            return products;
        }
    }
}