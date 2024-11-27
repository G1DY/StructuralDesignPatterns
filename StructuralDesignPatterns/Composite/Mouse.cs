using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composite
{
    public class Mouse : Item
    {
        private float _price = 29.00f;

        public float GetPrice()
        {
            return _price;
        }
    }
}