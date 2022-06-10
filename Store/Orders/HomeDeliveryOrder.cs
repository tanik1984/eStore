using Store.Delivery;

namespace Store.Orders
{
    public class HomeDeliveryOrder : Order<HomeDelivery>
    {
        public HomeDeliveryOrder(string number, HomeDelivery delivery)
            : base(number, delivery)
        {
        }
    }
}