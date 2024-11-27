using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.BadSln
{
    public class LGRemote : RemoteControl
    {
        public override void TurnOff()
        {
            System.Console.WriteLine("Turning the Radio Off");
        }

        public override void TurnOn()
        {
            System.Console.WriteLine("Turning the Radio On");
        }

        public override void VolumeDown()
        {
            System.Console.WriteLine("Radio Volume Down");
        }

        public override void VolumeUp()
        {
            System.Console.WriteLine("Radio volume Up");
        }
    }
}