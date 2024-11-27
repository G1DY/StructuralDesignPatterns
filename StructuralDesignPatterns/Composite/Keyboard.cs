using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composite
{
    public class Keyboard : Item
    {
        private float _price = 40.00f;

        public float GetPrice()
        {
            return _price;
        }
    }
}