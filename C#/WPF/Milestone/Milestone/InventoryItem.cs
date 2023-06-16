using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone
{
    class InventoryItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string WaxType { get; set; }
        public string WickType { get; set; }
        public string Color { get; set; }
        public string Scent { get; set; }
        public bool Shimmering { get; set; }
        public int Size { get; set; }
        public int Quantity { get; set; }
        public int LastOrderedQuantity { get; set; }
        public double Price { get; set; }
        public DateTime LastOrderedDate { get; set; }
        
        public InventoryItem()
        {
            
        }
        public InventoryItem(string name, string description, string waxType, string wickType, string color, string scent, bool shimmering, int size, int quantity, double price)
        {
            Name = name;
            Description = description;
            WaxType = waxType;
            WickType = wickType;
            Color = color;
            Scent = scent;
            Shimmering = shimmering;
            Size = size;
            Quantity = quantity;
            Price = price;
            LastOrderedQuantity = quantity;
            LastOrderedDate = DateTime.Now;
        }
        
    }
}
