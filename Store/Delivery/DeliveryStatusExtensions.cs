using System;

namespace Store.Delivery
{
    public static class DeliveryStatusExtensions
    {
        public static string AsDeliveryStatus(this bool value)
        {
            return value
                ? "готов к выдаче"
                : "не готов";
        }

        public static string AsDeliveryStatus(this HomeDeliveryStatus value)
        {
            switch (value)
            {
                case HomeDeliveryStatus.InPreparation:
                    return "готовится";
                case HomeDeliveryStatus.OnTheWay:
                    return "в пути";
                case HomeDeliveryStatus.Completed:
                    return "Доставлен";
                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }
    }
}