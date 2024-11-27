using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.GoodSln
{
    public interface Device
    {
        public void TurnOn();
        public void TurnOff();
        public void SetChannel(int channel);
    }
}