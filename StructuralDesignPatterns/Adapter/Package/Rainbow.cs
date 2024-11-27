using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter.Package
{
    public class Rainbow
    {
        public void SetUp()
        {
            System.Console.WriteLine("Setting up rainbow filter");
        }
        public void Update(Video video)
        {
            System.Console.WriteLine("Updating the rainbow color filter to colors");
        }
    }
}