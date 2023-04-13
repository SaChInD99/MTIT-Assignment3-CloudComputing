using System.Reflection;

namespace MTIT.Manager.Data
{
    public class ManagerMockDataService
    {
        public static List<Models.Manager> Managers = new List<Models.Manager>()
        {
            new Models.Manager { Id = 1, ItemName ="Bat",ItemQuantity ="10",ItemPrice =200000},
            new Models.Manager { Id = 2, ItemName ="Ball",ItemQuantity ="40",ItemPrice =22000},
            new Models.Manager { Id = 3, ItemName ="helmet",ItemQuantity ="78",ItemPrice =21000},
            new Models.Manager { Id = 4, ItemName ="sportswear ",ItemQuantity ="32",ItemPrice =23000},
            new Models.Manager { Id = 5, ItemName ="footwear",ItemQuantity ="65",ItemPrice =19000}

        };


    }
}
