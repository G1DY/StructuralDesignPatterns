using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter
{
    public class BlackAndWhite : Color
    {
        public void Apply(Video video)
        {
            System.Console.WriteLine("Applying Black and White Color");
        }
    }
}