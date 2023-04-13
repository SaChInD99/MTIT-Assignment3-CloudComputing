using System.Reflection;

namespace MTIT.Supplier.Mobile.Data
{
    public static class MobileMockDataService
    {
        public static List<Models.Mobile> Mobile = new List<Models.Mobile>()
        {
            new Models.Mobile { Id = 1, Brand = "Apple", Country = "USA", Price = 200000 },
            new Models.Mobile { Id = 2, Brand = "Huawei", Country = "China", Price  = 22000 },
            new Models.Mobile { Id = 3, Brand = "Samsung", Country = "Korea", Price  = 100000 },
            new Models.Mobile { Id = 4, Brand = "Oppo", Country = "India", Price  = 23000 },
            new Models.Mobile { Id = 5, Brand = "Nokia", Country = "Japan", Price  = 194500 }
        };
    }
}
