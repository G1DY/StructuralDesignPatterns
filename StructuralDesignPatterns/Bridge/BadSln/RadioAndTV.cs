using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.BadSln
{
    public abstract class RadioAndTV : RemoteControl
    {
        public abstract void ControlTv();
        public abstract void ControlRadio();
    }
}