using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composite
{
    public class Microphone : Item
    {
       private float _price = 18.00f;

        public float GetPrice()
        {
            return _price;
        }
    }
}