using StructuralDesignPatterns.Bridge.GoodSln;

var lgremote = new RemoteControl(new LGRadio());
lgremote.TurnOff();
lgremote.TurnOn();

var advanced = new AdvancedRemoteControl(new SonyRadio());
advanced.SetChannel(3);
