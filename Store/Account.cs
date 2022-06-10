using System.Collections.Generic;
using Store.Orders;

namespace Store
{
    public class Account
    {
        public Account()
        {
            Orders = new List<OrderBase>();

            foreach (var order in Orders)
            {
               order.ShowOrderInfo();
            }
        }

        public string Email { get; set; }

        public List<OrderBase> Orders { get; }
    }
}