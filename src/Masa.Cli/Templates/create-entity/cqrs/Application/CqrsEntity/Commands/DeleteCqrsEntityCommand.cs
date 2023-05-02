using Masa.BuildingBlocks.ReadWriteSplitting.Cqrs.Commands;

namespace ProjectNameSpaceApplication.CqrsEntity.Commands;

public record DeleteCqrsEntityCommand(Guid Id):Command
{
}
