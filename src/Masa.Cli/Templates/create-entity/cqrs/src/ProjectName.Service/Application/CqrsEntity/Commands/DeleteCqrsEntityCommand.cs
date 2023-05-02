using Masa.BuildingBlocks.ReadWriteSplitting.Cqrs.Commands;

namespace ProjectNameService.Application.CqrsEntity.Commands;

public record DeleteCqrsEntityCommand(Guid Id):Command
{
}
