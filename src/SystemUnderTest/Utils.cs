using System;

namespace SystemUnderTest
{
    public class Utils
    {
        public static void SendOrderConfirmationEmail(Order order)
        {
            throw new Exception("Cannot connect to email server.");
        }

        public static void SaveOrder(Order order)
        {
            // save the order somewhere
        }
    }
}
