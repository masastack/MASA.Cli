namespace Masa.Cli.ActionEvents;

public class EventHanlder
{
    [EventHandler]
    public async Task CreateEntity(CreateEntityCommand @event)
    {
        Console.WriteLine($"Start Create Entity……");
        var args = @event.GetCommandLineArgs();

        CreateEntityCommandBase actionCommand = new CqrsEntityCommand(args);

        if (args.Args.TryGetValue(CliConsts.CreateEntity.ModeKey, out string modeValue))
        {
            if (modeValue.Equals(CliConsts.CreateEntity.CqrsMode, StringComparison.CurrentCultureIgnoreCase))
            {
                actionCommand = new CqrsEntityCommand(args);
            }
            else if (modeValue.Equals(CliConsts.CreateEntity.DddMode, StringComparison.CurrentCultureIgnoreCase))
            {
                actionCommand = new DddEntityCommand(args);
            }
            else
            {
                throw new ArgumentException($"Parameter '-model={modeValue}' not found.");
            }
        }

        var eventBus = MasaApp.GetService<IEventBus>();
        await eventBus.PublishAsync(actionCommand);

        Console.WriteLine($"Create Success.");
    }

    [EventHandler]
    public Task New(NewCommand @event)
    {
        throw new NotImplementedException($"{@event.GetType().GetCommandName()} not implemented.");
    }
}
