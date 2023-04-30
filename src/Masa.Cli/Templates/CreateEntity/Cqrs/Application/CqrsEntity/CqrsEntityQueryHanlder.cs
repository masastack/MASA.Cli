using Masa.Contrib.Dispatcher.Events;
using ProjectNameSpace.Application.CqrsEntity.Queries;

namespace ProjectNameSpace.Application.CqrsEntity;

public class CqrsEntityQueryHanlder
{
    [EventHandler]
    public Task GetListAsync(GetListCqrsEntityQuery query)
    {
        return Task.CompletedTask;
    }

    [EventHandler]
    public Task GetAsync(GetCqrsEntityQuery query)
    {
        return Task.CompletedTask;
    }
}
