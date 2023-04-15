namespace MTIT.Transport.Models
{
    public class Transport
    {
        public int Id { get; set; }
        public string? TransportName { get; set; }
        public string? TransportLocation { get; set; }
        public int DeliveryCharge { get; set; }
    }
}
