namespace Masa.Cli;

public class Program
{
    private static async Task Main(string[] args)
    {
        IServiceCollection services = new ServiceCollection();

        services.AddEventBus();
    }
}