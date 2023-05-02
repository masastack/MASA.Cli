using Masa.Contrib.Dispatcher.Events;
using ProjectNameService.Application.CqrsEntity.Commands;

namespace ProjectNameService.Application.CqrsEntity;

public class CqrsEntityCommandHanlder
{
    // Use Business's DbContext
    public CqrsEntityCommandHanlder()
    {

    }

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
