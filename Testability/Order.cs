namespace Testability
{
    public class Order
    {
        public float TotalPrice { get; set; }
        public bool IsShipped { get; set; }
        public Shipment Shipment { get; set; }
    }
}