using Store.Delivery;

namespace Store.Orders
{
    public class PickPointDeliveryOrder : Order<PickPointDelivery>
    {
        public PickPointDeliveryOrder(string number, PickPointDelivery delivery)
            : base(number, delivery)
        {
        }
    }
}