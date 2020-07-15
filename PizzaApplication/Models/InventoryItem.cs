using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Models
{
    public enum InventoryItemType
    {
        size,
        flavor,
        Topping,
        Source,
        cheese
    }
    public class InventoryItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public InventoryItemType type { get; set; }
        public int QuantityRemaining { get; set; }
        public decimal PricePerUnit { get; set; }

    }
}
