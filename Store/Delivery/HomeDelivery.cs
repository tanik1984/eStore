using System;

namespace Store.Delivery
{
    public class HomeDelivery : DeliveryBase
    {
        public HomeDelivery(string deliveryCompany)
        {
            DeliveryCompany = deliveryCompany;
        }

        public HomeDeliveryStatus Status { get; set; }
        public string DeliveryCompany { get; }

        public override string GetDeliveryInfo()
        {
            return $"Доставка выполняется компанией {DeliveryCompany}{Environment.NewLine}Состояние заказа: {Status.AsDeliveryStatus()}";
        }
    }
}