using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageBusiness.Logic.Services
{
    public interface IPurchaseServices
    {
        List<Purchase> GetList();
    }
    public class PurchaseService:IPurchaseServices
    {

       public List<Purchase> GetList()
        {
            var purchase = new List<Purchase>
            {
                new Purchase
                {
                    GoodId = 5,
                    Amount = 9,
                    data = DateTime.Now
                },
                 new Purchase
                {
                    GoodId = 4,
                    Amount = 9,
                    data = DateTime.Now
                }
                 
            };
            return purchase;
        }
    }
}
