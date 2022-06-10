using Store.Delivery;

namespace Store.Orders
{
    public class ShopDeliveryOrder : Order<ShopDelivery>
    {
        public ShopDeliveryOrder(string number, ShopDelivery delivery)
            : base(number, delivery)
        {
        }
    }
}