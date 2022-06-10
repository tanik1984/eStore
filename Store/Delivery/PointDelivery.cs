using System;

namespace Store.Delivery
{
    public abstract class PointDelivery : DeliveryBase
    {
        protected PointDelivery(string address)
        {
            Address = address;
        }

        public string Address { get; }
        public bool IsReadyForPickup { get; set; }

        public override string GetDeliveryInfo()
        {
            return
                $"Доставка в {GetPointName()} по адресу {Address}{Environment.NewLine}Состояние заказа: {IsReadyForPickup.AsDeliveryStatus()}";
        }

        protected abstract string GetPointName();
    }
}