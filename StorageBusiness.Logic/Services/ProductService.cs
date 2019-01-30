using Newtonsoft.Json;
using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageBusiness.Logic.Services
{
    public interface IProductService
    {
        void Add(Product category);

        void Update(Product category);

        void Delete(int id);

        List<Product> GetAll();

        Product GetList(int id);
    }

    public class ProductService : ServiceBase, IProductService
    {
        private const string FilePath = @"\bin\Product.txt";

        private List<Product> _products;

        public ProductService()
        {
            var savedData = ReadData();

            _products =
                savedData != null
                ? savedData
                : new List<Product>();
        }

        public void Add(Product product)
        {
            int id = GetMaxId(_products
                                    .OfType<Product>()
                                    .ToList());

            product.Id = id + 1;

            _products.Add(product);

            SaveChanges();
        }

        public void Delete(int id)
        {
            var product = GetList(id);

            if (product != null)
            {
                _products.Remove(product);
            }

            SaveChanges();
        }

        public Product GetList(int id)
        {
            return _products
                        .FirstOrDefault(x => x.Id == id);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            var oldCategory = GetList(product.Id);

            oldCategory.Name = product.Name;

            SaveChanges();
        }

        private List<Product> ReadData()
        {
            var data = File.ReadAllText(GetStoragePath(FilePath));

            return JsonConvert.DeserializeObject<List<Product>>(data);
        }

        private void SaveChanges()
        {
            var data = JsonConvert.SerializeObject(_products);

            File.WriteAllText(GetStoragePath(FilePath), data);
        }
    }
}
