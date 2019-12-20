using System;
using System.Linq;

namespace SystemUnderTest
{
    public class OrderService
    {
        private int _orderCount = 0;

        // A void method whose success cannot be verified by its returned result
        // Verifying thrown exceptions is straightforward, but what about successful execution?
        public void PlaceOrder(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            if(!order.Items.Any())
            {
                return;
            }

            SaveOrder(order);

            Utils.SendOrderConfirmationEmail(order);

            _orderCount++;
        }

        private void SaveOrder(Order order)
        {
            throw new Exception("Can't connect to database.");
        }
    }
}
