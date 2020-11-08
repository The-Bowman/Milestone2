using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone2
{
    class Driver
    {
        private static List<InventoryItem> items = new List<InventoryItem>();
        static void Main(String[] args)
        {
            InventoryItem item = new InventoryItem();
            item.getPrice();
            item.getItemNum();
            Console.WriteLine(item.getItemName());
            item = new InventoryItem("Silver Nonsense Scribbler", "A pen in a silver chassis.", 555618, 19.99);

            items.Add(item);
            Console.WriteLine (items[0].getItemName());
        }
    }
}
