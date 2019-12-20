using System.Collections.Generic;

namespace SystemUnderTest
{
    public class Order
    {
        public string CustomerEmail { get; }
        private List<OrderItem> _items = new List<OrderItem>();
        public IEnumerable<OrderItem> Items => _items.AsReadOnly();

        // An easily tested public method with return type and modified public property
        public bool AddItem(OrderItem item)
        {
            if (item == null) return false;
            _items.Add(item);
            return true;
        }
    }
}
