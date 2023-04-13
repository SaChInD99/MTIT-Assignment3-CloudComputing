using MTIT.Supplier.Mobile.Data;
using MTIT.Supplier.Mobile.Models;


namespace MTIT.Supplier.Mobile.Services
{
    public class MobileService : IMobileService
    {
        public List<Models.Mobile> GetMobile()
        {
            return MobileMockDataService.Mobile;
        }

        public Models.Mobile? GetMobile(int id)
        {
            return MobileMockDataService.Mobile.FirstOrDefault(x => x.Id == id);
        }

        public Models.Mobile? AddMobile(Models.Mobile mobile)
        {
            MobileMockDataService.Mobile.Add(mobile);
            return mobile;
        }

        public Models.Mobile? UpdateMobile(Models.Mobile mobile)
        {
            Models.Mobile selectedMobile = MobileMockDataService.Mobile.FirstOrDefault(x => x.Id == mobile.Id);
            if (selectedMobile != null)
            {
                selectedMobile.Country = mobile.Country;
                selectedMobile.Price = mobile.Price;
                selectedMobile.Brand = mobile.Brand;
                return selectedMobile;
            }

            return selectedMobile;
        }

        public bool? DeleteMobile(int id)
        {
            Models.Mobile selectedMobile = MobileMockDataService.Mobile.FirstOrDefault(x => x.Id == id);
            if (selectedMobile != null)
            {
                MobileMockDataService.Mobile.Remove(selectedMobile);
                return true;
            }
            return false;
        }
    }
}