namespace Store.Delivery
{
    public class PickPointDelivery : PointDelivery
    {
        public PickPointDelivery(string address)
            : base(address)
        {
        }

        protected override string GetPointName()
        {
            return "пункт выдачи";
        }
    }
}