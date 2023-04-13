using MTIT.Manager.Data;

namespace MTIT.Manager.Services
{
    public class ManagerService : IManagerService
    {
        public List<Models.Manager> GetManagers()
        {
            return ManagerMockDataService.Managers;

        }

        public Models.Manager? GetManager(int id)
        {
            return ManagerMockDataService.Managers.FirstOrDefault(x => x.Id == id);
        }

        public Models.Manager? AddManager(Models.Manager manager)
        {
            ManagerMockDataService.Managers.Add(manager);
            return manager;
        }




        public Models.Manager? UpdateManager(Models.Manager manager)
        {
            Models.Manager selectedManager = ManagerMockDataService.Managers.FirstOrDefault(x => x.Id == manager.Id);
            if (selectedManager != null)
            {
                selectedManager.ItemName = manager.ItemName;
                selectedManager.ItemQuantity = manager.ItemQuantity;
                selectedManager.ItemPrice = manager.ItemPrice;
                return selectedManager;
            }
            return selectedManager;

        }




        public bool? DeleteManager(int id)
        {
            Models.Manager selectedManager = ManagerMockDataService.Managers.FirstOrDefault(x => x.Id == id);
            if (selectedManager != null)
            {
                ManagerMockDataService.Managers.Remove(selectedManager);
                return true;

            }
            return false;

        }
    }
}
