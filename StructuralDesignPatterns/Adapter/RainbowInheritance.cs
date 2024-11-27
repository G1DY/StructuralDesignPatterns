using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralDesignPatterns.Adapter.Package;

namespace StructuralDesignPatterns.Adapter
{
    public class RainbowInheritance : Rainbow, Color
    {
        public void Apply(Video video)
        {
            SetUp();
            Update(video);
        }
    }
}