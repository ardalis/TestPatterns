using System.Collections.Generic;

namespace SystemUnderTest
{
    public class Order
    {
        private List<OrderItem> _items = new List<OrderItem>();
        public IEnumerable<OrderItem> Items => _items.AsReadOnly();

        public bool AddItem(OrderItem item)
        {
            if (item == null) return false;
            _items.Add(item);
            return true;
        }
    }
}
