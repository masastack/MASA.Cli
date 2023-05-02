using Masa.BuildingBlocks.ReadWriteSplitting.Cqrs.Queries;
using Masa.Utils.Models;
using ProjectNameContracts.CqrsEntity;

namespace ProjectNameService.Application.CqrsEntity.Queries;

public record GetListCqrsEntityQuery(string Keyword = "", int Page = 1, int PageSize = 10) : Query<PaginatedListBase<GetListCqrsEntityDto>>
{
    public override PaginatedListBase<GetListCqrsEntityDto> Result { get; set; }
}
