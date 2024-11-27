using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.GoodSln
{
    public class SonyRadio : Device
    {
        public void SetChannel(int channel)
        {
            System.Console.WriteLine("Setting up channel: " + channel);
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Turning Off Sony Radio");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turning on Sony Radio");
        }
    }
}