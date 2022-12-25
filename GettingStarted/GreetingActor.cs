using Proto;

namespace GettingStarted;

internal readonly record struct Greet(string Who);

public class GreetingActor : IActor
{
    public Task ReceiveAsync(IContext ctx)
    {
        if (ctx.Message is Greet greet)
        {
            Console.WriteLine($"Hello {greet.Who}");
        }
        return Task.CompletedTask;
    }
}