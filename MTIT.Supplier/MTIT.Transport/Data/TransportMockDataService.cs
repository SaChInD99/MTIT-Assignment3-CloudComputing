using MTIT.Transport.Models;
using System.Reflection;

namespace MTIT.Transport.Data
{
    public class TransportMockDataService
    {
        public static List<Models.Transport> Transports = new List<Models.Transport>()
        {
            new Models.Transport { Id = 1, TransportName = "LLC", TransportLocation = "Main St, California", DeliveryCharge = 2000 },
            new Models.Transport { Id = 2, TransportName = "JBC", TransportLocation = "Second Ave, LA", DeliveryCharge = 2200 },
            new Models.Transport { Id = 3, TransportName = "HCB", TransportLocation = "Third St, Vegas", DeliveryCharge = 2100 },
            new Models.Transport { Id = 4, TransportName = "MMR", TransportLocation = "Fourth Ave, NY", DeliveryCharge = 2300 },
            new Models.Transport { Id = 5, TransportName = "GCD", TransportLocation = "4 Fifth St, New Jersy", DeliveryCharge = 1900 }
        };
    }
}
