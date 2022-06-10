namespace Store.Delivery
{
    public class ShopDelivery : PointDelivery
    {
        public ShopDelivery(string address)
            : base(address)
        {
        }


        protected override string GetPointName()
        {
            return "магазин";
        }
    }
}