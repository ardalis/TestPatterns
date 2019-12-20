using System;
using SystemUnderTest;
using Xunit;

namespace UnitTests
{
    public class OrderAddItem
    {
        private Order _order = new Order();

        [Fact]
        public void ReturnsFalseGivenNullItem()
        {
            var result = _order.AddItem(null);

            Assert.False(result);
        }

        [Fact]
        public void ReturnsTrueGivenNonNullItem()
        {
            var result = _order.AddItem(new OrderItem());

            Assert.True(result);
        }

        [Fact]
        public void AddsItemToItemsCollection()
        {
            var item = new OrderItem();
            _order.AddItem(item);

            Assert.Contains(item, _order.Items);
        }
    }
}
