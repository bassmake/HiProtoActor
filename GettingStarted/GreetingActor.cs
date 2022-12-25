using Proto;

namespace GettingStarted;

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