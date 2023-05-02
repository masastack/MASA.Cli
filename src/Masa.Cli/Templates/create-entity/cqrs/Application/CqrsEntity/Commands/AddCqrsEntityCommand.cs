using Masa.BuildingBlocks.ReadWriteSplitting.Cqrs.Commands;
using ProjectNameSpaceContracts.CqrsEntity;

namespace ProjectNameSpaceApplication.CqrsEntity.Commands;

public record AddCqrsEntityCommand(AddCqrsEntityDto Dto) : Command
{
}
