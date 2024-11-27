using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.BadSln
{
    public abstract class AdvancedRemote : RemoteControl
    {
        public abstract void SetChannel(int channel);
    }
}