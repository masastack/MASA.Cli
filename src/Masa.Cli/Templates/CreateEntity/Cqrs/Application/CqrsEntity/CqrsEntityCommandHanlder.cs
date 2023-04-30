using Masa.Contrib.Dispatcher.Events;
using ProjectNameSpace.Application.CqrsEntity.Commands;

namespace ProjectNameSpace.Application.CqrsEntity;

public class CqrsEntityCommandHanlder
{
    [EventHandler]
    public Task AddCqrsEntityAsync(AddCqrsEntityCommand command)
    {
        return Task.CompletedTask;
    }

    [EventHandler]
    public Task UpdateCqrsEntityAsync(UpdateCqrsEntityCommand command)
    {
        return Task.CompletedTask;
    }

    [EventHandler]
    public Task DeleteCqrsEntityAsync(DeleteCqrsEntityCommand command)
    {
        return Task.CompletedTask;
    }
}
