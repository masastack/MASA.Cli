using Masa.Contrib.Dispatcher.Events;
using ProjectNameSpaceApplication.CqrsEntity.Queries;

namespace ProjectNameSpaceApplication.CqrsEntity;

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
