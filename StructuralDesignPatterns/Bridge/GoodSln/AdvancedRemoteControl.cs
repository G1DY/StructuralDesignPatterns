using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.GoodSln
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(Device device) : base(device)
        {
        }
        public void SetChannel(int channel)
        {
            System.Console.WriteLine("Setting up channel: " + channel);
        }
    }

}