using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone
{
    class InventoryManager
    {
        bool alreadyInList = false;
        public List<InventoryItem> inventoryList = new List<InventoryItem>();
        public List<List<string>> rows = new List<List<string>>();

        //This method adds a new item to the inventory.
        public bool CreateItem(string name, string description, string waxType, string wickType, string color, string scent, bool shimmering, int size, int quantity, double price)
        {
            alreadyInList = false;
            for (int i = 0; i < inventoryList.Count; i++)
            {
                if (name == inventoryList[i].Name)
                {
                    Console.WriteLine(name + " already exists in the list");
                    alreadyInList = true;
                }
            }
            if (alreadyInList == false)
            {
                inventoryList.Add(new InventoryItem(name, description, waxType, wickType, color, scent, shimmering, size, quantity, price));
            }
            return alreadyInList;
        }

        //This method takes in an items name and removes the corresponding item from the inventory.
        public void RemoveItem(string name)
        {
            for (int i = 0; i < inventoryList.Count; i++)
            {
                if (name == inventoryList[i].Name)
                {
                    inventoryList.RemoveAt(i);
                }
            }
        }

        //This method takes in an inventory items name and quantity you wish to increase it by. It increses the inventory
        //item by that amount and adds an entry in the rows List that will be used in the Order screen to view past orders.
        public bool RestockItem(string name, int quantity)
        {
            List<string> row = new List<string>();
            alreadyInList = false;
            for(int i = 0; i < inventoryList.Count; i++)
            {
                if (name == inventoryList[i].Name)
                {
                    alreadyInList = true;
                    inventoryList[i].Quantity += quantity;
                    row.Add(inventoryList[i].Name);
                    row.Add(inventoryList[i].Description);
                    row.Add(inventoryList[i].Quantity.ToString());
                    row.Add(quantity.ToString());
                    row.Add(inventoryList[i].LastOrderedDate.ToString());
                    inventoryList[i].LastOrderedQuantity = quantity;
                    inventoryList[i].LastOrderedDate = DateTime.Now;
                    rows.Add(row);
                }
            }
            return alreadyInList;
        }

        //This method returns a list of all current items in the inventory for refreshing and/or updating.
        public List<InventoryItem> DisplayItems()
        {
            return inventoryList;
        }

        //This method takes in the selected radio button, and the search criteria and returns a list of items that match
        //the search criteria.
        public List<InventoryItem> LookupItem(string radioSelected, string search)
        {
            List<InventoryItem> tempList = new List<InventoryItem>();
            switch (radioSelected)
            {
                case "Name":
                    {
                        for (int i = 0; i < inventoryList.Count; i++)
                        {
                            if (search.ToLower() == inventoryList[i].Name.ToLower())
                            {
                                tempList.Add(inventoryList[i]);
                            }
                        }
                        break;
                    }
                case "Scent":
                    {
                        for (int i = 0; i < inventoryList.Count; i++)
                        {
                            if (search.ToLower() == inventoryList[i].Scent.ToLower())
                            {
                                tempList.Add(inventoryList[i]);
                            }
                        }
                        break;
                    }
                case "Color":
                    {
                        for (int i = 0; i < inventoryList.Count; i++)
                        {
                            if (search.ToLower() == inventoryList[i].Color.ToLower())
                            {
                                tempList.Add(inventoryList[i]);
                            }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("There was an error adding the item.");
                        break;
                    }
            }
            return tempList;        
        }
            
    }
}
