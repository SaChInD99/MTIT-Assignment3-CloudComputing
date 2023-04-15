using System.Reflection;

namespace MTIT.Manager.Data
{
    public class ManagerMockDataService
    {
        public static List<Models.Manager> Managers = new List<Models.Manager>()
        {
            new Models.Manager { Id = 1, ItemName ="Dialog Broadband",ItemQuantity ="15",ItemPrice =200000},
            new Models.Manager { Id = 2, ItemName ="Dialog TV",ItemQuantity ="40",ItemPrice =22000},
            new Models.Manager { Id = 3, ItemName ="Dialog Phone",ItemQuantity ="78",ItemPrice =21000},
            new Models.Manager { Id = 4, ItemName ="Dialog Satellite ",ItemQuantity ="32",ItemPrice =23000},
            new Models.Manager { Id = 5, ItemName ="Dialog Adapter",ItemQuantity ="65",ItemPrice =19000}

        };


    }
}
