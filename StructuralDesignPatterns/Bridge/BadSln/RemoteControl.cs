using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.BadSln
{
    public abstract class RemoteControl
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void VolumeUp();
        public abstract void VolumeDown();
        
    }
}
// CLIENTSIDECODE:
// var lgRemote = new LGRemote();
// lgRemote.TurnOff();
// lgRemote.TurnOn();

// var lgradioandtv = new LGAdvancedRemote();
// lgradioandtv.TurnOff();
// lgradioandtv.SetChannel(1);
