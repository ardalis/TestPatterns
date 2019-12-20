using System;
using System.Linq;

namespace SystemUnderTest
{
    public class OrderService
    {
        public bool PlaceOrder(Order order)
        {
            if(order.Items.Count() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
