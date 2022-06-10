using System;
using Store.Delivery;

namespace Store.Orders
{
    public abstract class Order<TDelivery> : OrderBase
        where TDelivery : DeliveryBase
    {
        protected Order(string number, TDelivery delivery)
            : base(number)
        {
            Delivery = delivery;
        }

        public TDelivery Delivery { get; }

        public override void ShowOrderInfo()
        {
            var deliveryInfo = Delivery.GetDeliveryInfo();

            Console.WriteLine(deliveryInfo);
        }
    }
}