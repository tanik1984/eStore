using System.Collections.Generic;

namespace Store.Orders
{
    public abstract class OrderBase
    {
        protected OrderBase(string number)
        {
            Number = number;

            Products = new List<Product>();
        }

        public string Number { get; }
        public List<Product> Products { get; }
        public abstract void ShowOrderInfo();
    }
}