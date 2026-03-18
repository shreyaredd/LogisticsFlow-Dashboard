namespace LogisticsFlow.Models 
{
    public class Shipment 
    {
        public int Id { get; set; } 
        public string TrackingNumber { get; set; }
        public string CarrierName { get; set; } 
        public string Status { get; set; } 
        public string Destination { get; set; }
    }
}