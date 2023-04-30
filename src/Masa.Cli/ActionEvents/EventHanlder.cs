namespace Masa.Cli.ActionEvents;

public class EventHanlder
{
    [EventHandler]
    public async Task CreateEntity(CreateEntityCommand @event)
    {
        var args = @event.GetCommandLineArgs();

        Type createType = null;
        foreach (var item in typeof(CreateEntityCommandBase).GetChildClasses())
        {
            if (item.IsCommandName(args.Target, "EntityCommand"))
            {
                createType = item;
                break;
            }
        }
        if (createType == null)
        {
            Console.WriteLine("Entity Type not found.");
        }

        var actionCommand = (CreateEntityCommandBase)Activator.CreateInstance(createType, args);
        var eventBus = MasaApp.GetService<IEventBus>();
        await eventBus.PublishAsync(actionCommand);

    }

    [EventHandler]
    public Task New(NewCommand @event)
    {
        throw new NotImplementedException($"{@event.GetType().GetCommandName()} not implemented.");
    }
}
