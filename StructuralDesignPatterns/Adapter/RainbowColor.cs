using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralDesignPatterns.Adapter.Package;

namespace StructuralDesignPatterns.Adapter
{
    public class RainbowColor : Color
    {
        private Rainbow _rainbow;
        public RainbowColor(Rainbow rainbow)
        {
            _rainbow = rainbow;
        }
        public void Apply(Video video)
        {
            _rainbow.SetUp();
            _rainbow.Update(video);
        }
    }
}