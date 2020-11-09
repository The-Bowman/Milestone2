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
            InventoryItem item1 = new InventoryItem("Silver Nonsense Scribbler", "A pen in a silver chassis.", 555618, 19.99);

            items.Add(item);
            items.Add(item1);

            InventoryItem.showAllItems(items);

            Console.WriteLine("The following tests all setter methods:");

            items[0].setItemName("X-Wing Starfighter");
            item.setDescr("Rise up with the Resistance and take down the First Order!");
            item.setItemNum(8675309);
            item.setPrice(19.99);

            InventoryItem.showAllItems(items);
        }
    }
}
