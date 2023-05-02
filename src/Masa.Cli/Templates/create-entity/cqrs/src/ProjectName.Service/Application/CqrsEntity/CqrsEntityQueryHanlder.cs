using Masa.Contrib.Dispatcher.Events;
using ProjectNameService.Application.CqrsEntity.Queries;

namespace ProjectNameService.Application.CqrsEntity;

public class CqrsEntityQueryHanlder
{

    // Use Query's DbContext
    public CqrsEntityQueryHanlder()
    {

    }

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
