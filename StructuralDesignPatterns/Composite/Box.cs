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
// CLIENTSIDECODE:
// var package = new Box();

// var box1 = new Box();
// box1.Add(new Microphone());

// var box2 = new Box();

// var box3 = new Box();
// box3.Add(new Mouse());

// var box4 = new Box();
// box4.Add(new Keyboard());

// box2.Add(box3);
// box2.Add(box4);

// package.Add(box1);
// package.Add(box2);

// System.Console.WriteLine("TotalPrice is : " + package.GetPrice());