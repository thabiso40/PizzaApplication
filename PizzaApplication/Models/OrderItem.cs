using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Models
{
    public enum OrderItemType
    {
        Pizza,
        Drink,
        Bread,
        Chicken
    }
    public class OrderItem
    {
        public int ID { get; set; }
        public OrderItemType type { get; set; }
        public decimal Price { get; set; }
        IEnumerable<InventoryItem> OrderItemDetails { get; set; }
    }
}
