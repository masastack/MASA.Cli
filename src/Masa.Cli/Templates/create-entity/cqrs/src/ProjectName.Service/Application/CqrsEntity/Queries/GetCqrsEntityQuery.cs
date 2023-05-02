using Masa.BuildingBlocks.ReadWriteSplitting.Cqrs.Queries;
using ProjectNameContracts.CqrsEntity;

namespace ProjectNameService.Application.CqrsEntity.Queries;

public record GetCqrsEntityQuery(Guid Id) : Query<GetCqrsEntityDto>
{
    public override GetCqrsEntityDto Result { get; set; }
}
