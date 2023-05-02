using System.IO;

namespace Masa.Cli;

public class Program
{
    private static async Task Main(string[] args)
    {
        try
        {
            if (args.IsNullOrEmpty())
            {
                //TODO:Helper Command
                Console.WriteLine("Please input create-entity or new command.");
            }

            IServiceCollection services = new ServiceCollection();
            services.AddEventBus().AddAutoInject();
            MasaApp.SetServiceCollection(services);


            var action = args[0];
            Type actionType = null;
            foreach (var item in typeof(ActionCommandBase).GetChildClasses())
            {
                if (item.IsCommandName(action))
                {
                    actionType = item;
                    break;
                }
            }
            if (actionType == null)
            {
                Console.WriteLine($"Command '{action}' not found.");
            }

            var actionCommand = (ActionCommandBase)Activator.CreateInstance(actionType, new object[] { args });
            var eventBus = MasaApp.GetService<IEventBus>();

            await eventBus.PublishAsync(actionCommand);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}