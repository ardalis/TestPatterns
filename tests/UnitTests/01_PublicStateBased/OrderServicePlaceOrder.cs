using System;
using SystemUnderTest;
using Xunit;

namespace UnitTests
{
    public class OrderServicePlaceOrder
    {
        private OrderService _orderService = new OrderService();

        [Fact]
        public void ThrowsArgumentNullExceptionGivenNullOrder()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => _orderService.PlaceOrder(null));

            Assert.Equal("order", exception.ParamName);
        }

        [Fact]
        public void DoesNothingGivenEmptyOrder()
        {
            _orderService.PlaceOrder(new Order());

            // nothing else to assert. If we get here without exception, we pass?
        }
    }
}
