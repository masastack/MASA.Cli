using Masa.Utils.Models;
using Microsoft.AspNetCore.Builder;
using ProjectNameService.Application.CqrsEntity.Commands;
using ProjectNameService.Application.CqrsEntity.Queries;
using ProjectNameContracts.CqrsEntity;

namespace ProjectNameServices;

public class CqrsEntityService : ServiceBase
{
    private IEventBus _eventBus => GetRequiredService<IEventBus>();

    public async Task<PaginatedListBase<GetListCqrsEntityDto>> GetListAsync(string keyword = "", int page = 1, int pageSize = 10)
    {
        GetListCqrsEntityQuery query = new(keyword, page, pageSize);
        await _eventBus.PublishAsync(query);
        return query.Result;
    }

    public async Task<GetCqrsEntityDto> GetAsync(Guid id)
    {
        GetCqrsEntityQuery query = new(id);
        await _eventBus.PublishAsync(query);
        return query.Result;
    }

    public async Task AddAsync(AddCqrsEntityDto dto)
    {
        AddCqrsEntityCommand command = new(dto);
        await _eventBus.PublishAsync(command);
    }

    public async Task UpdateAsync(Guid id, UpdateCqrsEntityDto dto)
    {
        UpdateCqrsEntityCommand command = new(id, dto);
        await _eventBus.PublishAsync(command);
    }

    public async Task DeleteAsync(Guid id)
    {
        DeleteCqrsEntityCommand commandcommand = new(id);
        await _eventBus.PublishAsync(commandcommand);
    }
}
