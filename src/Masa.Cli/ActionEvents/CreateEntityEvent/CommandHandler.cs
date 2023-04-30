using Masa.Cli.ActionEvents.CreateEntityEvent.Commands;

namespace Masa.Cli.ActionEvents.CreateEntityEvent;

public class CommandHandler
{
    [EventHandler]
    public Task CreateCqrsEntity(CqrsEntityCommand @event)
    {
        throw new NotImplementedException();
    }

    [EventHandler]
    public Task CreateDddEntity(DddEntityCommand @event)
    {
        throw new NotImplementedException();
    }
}
