using Masa.Contrib.Dispatcher.Events;
using ProjectNameSpaceApplication.CqrsEntity.Commands;

namespace ProjectNameSpaceApplication.CqrsEntity;

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
