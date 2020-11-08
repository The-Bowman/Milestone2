using System;

namespace Milestone2
{
    class InventoryItem
    {
        private string itemName;
        private string itemDescr;
        private int itemNum;
        private double price;

        //Constructor methods
        public InventoryItem()
        {
            itemName = "Unknown";
            itemDescr = "Unknown";
            itemNum = 999;
            price = 999.99;
        }

        public InventoryItem(string itemName, string itemDescr, int itemNum, double price)
        {
            this.itemName = itemName;
            this.itemDescr = itemDescr;
            this.itemNum = itemNum;
            this.price = price;
        }


        //getter and setter methods for variables
        public int getItemNum()
        {
            return itemNum;
        }

        public void setItemNum(int itemNum)
        {
            this.itemNum = itemNum;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public string getItemName()
        {
            return itemName;
        }

        public void setItemName(string itemName)
        {
            this.itemName = itemName;
        }

        public string getDescr()
        {
            return itemDescr;
        }

        public void setDescr(string itemDescr)
        {
            this.itemDescr = itemDescr;
        }


    }
}
