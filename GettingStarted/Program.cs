using GettingStarted;
using Proto;

var system = new ActorSystem();
var props = Props.FromProducer(() => new GreetingActor());
var greeter = system.Root.Spawn(props);

system.Root.Send(greeter, new Greet("world"));

Console.ReadLine();