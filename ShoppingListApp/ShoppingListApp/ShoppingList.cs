using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp
{
    public class ShoppingList
    {
        private int CountOfItems;
        private string[] ItemsToBuy;
        public ShoppingList()
        {
            CountOfItems = 0;
            ItemsToBuy = new string[5];
        }
        public void AddItem(string item)
        {
            throw new NotImplementedException();
        }
        public int Size()
        {
            throw new NotImplementedException();
        }
        public string GetList()
        {
            throw new NotImplementedException();
        }
    }
}
