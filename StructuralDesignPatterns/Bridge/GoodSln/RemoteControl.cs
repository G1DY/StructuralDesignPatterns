using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.GoodSln
{
    public class RemoteControl
    {
        private Device _device;
        public RemoteControl(Device device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            _device.TurnOn();
        }
        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}
// CLIENTSIDECODE:
// var lgremote = new RemoteControl(new LGRadio());
// lgremote.TurnOff();
// lgremote.TurnOn();

// var advanced = new AdvancedRemoteControl(new SonyRadio());
// advanced.SetChannel(3);