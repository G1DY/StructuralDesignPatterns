using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composite
{
    public class Box : Item
    {
        private List<Object> _items = new List<Object>();
        public void Add(Item item)
        {
            _items.Add(item);
        }
        public float GetPrice()
        {
            float total = 0;
            foreach (Item item in _items)
            {
                total += item.GetPrice();
            }
            return total;
        }
    }
}