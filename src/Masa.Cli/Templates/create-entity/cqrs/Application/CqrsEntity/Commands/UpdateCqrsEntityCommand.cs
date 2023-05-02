using Masa.BuildingBlocks.ReadWriteSplitting.Cqrs.Commands;
using ProjectNameSpaceContracts.CqrsEntity;

namespace ProjectNameSpaceApplication.CqrsEntity.Commands;

public record UpdateCqrsEntityCommand(Guid Id, UpdateCqrsEntityDto Dto) : Command
{
}
