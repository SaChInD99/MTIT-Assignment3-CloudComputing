namespace MTIT.Supplier.Mobile.Services
{
    public interface IMobileService
    {
        List<Models.Mobile> GetMobile();
        Models.Mobile? GetMobile(int id);
        Models.Mobile? AddMobile(Models.Mobile mobile);
        Models.Mobile? UpdateMobile(Models.Mobile mobile);
        bool? DeleteMobile(int id);

    }
}

