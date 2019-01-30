using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageBusiness.Logic.Services
{

    public interface IArrivalServices
    {
        List<Arrival> GetLIst();
    }
    class ArrivalServices : IArrivalServices
    {
        public List<Arrival> GetLIst()
        {
            var arrival =
                new List<Arrival>
                {
                    new Arrival
                    {
                        GoodId = 1,
                        Amount =7,
                        data = DateTime.Now
                    },
                    new Arrival
                    {
                        GoodId = 2,
                        Amount = 8,
                        data = DateTime.Now
                    }
                };

            return arrival;
        }
    }
}
