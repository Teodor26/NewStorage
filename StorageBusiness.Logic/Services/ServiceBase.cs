using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageBusiness.Logic.Services
{
    public abstract class ServiceBase
    {
        public int GetMaxId(List<Product> entities)
        {
            if (entities == null || !entities.Any())
                return 0;

            return entities.Max(e => e.Id);
        }

        protected string GetStoragePath(string fileName)
        {
            return $@"{AppDomain.CurrentDomain.BaseDirectory}\{fileName}";
        }
    }
}
