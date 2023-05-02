using Masa.BuildingBlocks.ReadWriteSplitting.Cqrs.Queries;
using ProjectNameSpaceContracts.CqrsEntity;

namespace ProjectNameSpaceApplication.CqrsEntity.Queries;

public record GetCqrsEntityQuery(Guid Id) : Query<GetCqrsEntityDto>
{
    public override GetCqrsEntityDto Result { get; set; }
}
