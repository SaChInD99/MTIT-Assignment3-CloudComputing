using MTIT.Transport.Data;

namespace MTIT.Transport.Services
{
    public class TransportService : ITransportService
    {
        public List<Models.Transport> GetTransports()
        {
            return TransportMockDataService.Transports;
        }

        public Models.Transport? GetTransport(int id)
        {
            return TransportMockDataService.Transports.FirstOrDefault(x => x.Id == id);
        }

        public Models.Transport? AddTransport(Models.Transport transport)
        {
            TransportMockDataService.Transports.Add(transport);
            return transport;
        }

        public Models.Transport? UpdateTransport(Models.Transport transport)
        {
            Models.Transport selectedTransport = TransportMockDataService.Transports.FirstOrDefault(x => x.Id == transport.Id);
            if (selectedTransport != null)
            {
                selectedTransport.TransportName = transport.TransportName;
                selectedTransport.TransportLocation = transport.TransportLocation;
                selectedTransport.DeliveryCharge = transport.DeliveryCharge;
                return selectedTransport;
            }

            return selectedTransport;
        }

        public bool? DeleteTransport(int id)
        {
            Models.Transport selectedTransport = TransportMockDataService.Transports.FirstOrDefault(x => x.Id == id);
            if (selectedTransport != null)
            {
                TransportMockDataService.Transports.Remove(selectedTransport);
                return true;
            }
            return false;
        }
    }
}
